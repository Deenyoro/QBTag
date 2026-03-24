# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Overview

QBTag is a .NET Framework 4.0 WinForms application for Abanaki that prints product tags from QuickBooks sales orders. It queries QuickBooks Desktop via the QBFC12 SDK, stores processed order data in an Access database (usman.mdb), and generates printable labels via Crystal Reports with optional QR codes.

**This is a decompiled codebase** — the code was recovered from compiled binaries and may have non-standard naming, missing comments, or unusual patterns.

## Build

```
dotnet restore QBTag.sln
msbuild QBTag.sln -p:Configuration=Release
```

Output: `QBTag/bin/Release/net40/`

No test projects exist in this solution.

## Requirements

- .NET Framework 4.0 (all projects target `net40`, except Interop.QBFC12Lib which targets `net20`)
- C# LangVersion 12.0, AllowUnsafeBlocks enabled across all projects
- Platform target: x86 (required for COM interop with QuickBooks)
- QuickBooks Desktop with QBFC12 SDK installed
- Crystal Reports Runtime
- Microsoft Jet OLEDB 4.0 (for Access database)

## CLI

The app has a CLI mode (runs when launched with arguments). Key commands:

```
QBTag --help          Show usage
QBTag --version       Show version
QBTag --doctor        Full diagnostic check (files, DB, QB connection, config, logs)
QBTag --connect       Test QuickBooks connection
QBTag --status        Show file and path status
QBTag --config        Show current configuration
QBTag --init-db [path]  Create Access database at path (default: %LocalAppData%\QBTag\usman.mdb)
QBTag --set-db <path>   Set database path in settings
QBTag --test-db       Verify database opens and tables exist
QBTag --list-orders   List orders in database
QBTag --list-parts    List configured part types
QBTag --add-report <path>  Register a custom .rpt report template
QBTag --list-reports  Show built-in and custom reports
QBTag --reset-config  Reset all settings to defaults
QBTag --logs          Show last 50 lines of latest log
QBTag --logs clear    Delete all log files
```

CLI entry point: `CLI.cs` uses P/Invoke (`AttachConsole`/`AllocConsole`) to attach stdout to the parent console since this is a WinExe.

## Architecture

### Dependency Graph

```
QBTag (WinForms UI + CLI)
  ├── QuickBooksHandler (business logic - thin wrappers over DAL)
  │    └── QuickBooksDAL (data access - ODBC for QB, OleDb for Access)
  │         ├── QBSalesOrder (QBFC12 SDK queries)
  │         │    ├── QBHelpers (QB session management, registration, settings)
  │         │    │    ├── Logs (file logging with rotation)
  │         │    │    └── Interop.QBFC12Lib (COM interop types)
  │         │    └── Logs
  │         └── QuickBooksModel (POCOs: OrderInfo, SalesOrderLine, Parts, QrCodes, Motor, Belt)
  ├── QuickBooksModel
  └── QBSalesOrder
```

### Data Flow

1. **QB Query**: `ObjSalesOrder.GetSalesOrders()` uses QBFC12 SDK to query QuickBooks by order number, number range, or date range
2. **Data Mapping**: `SALESORDERLINEDAL.NEW_fetchSalesOrderLine()` parses QB `ISalesOrderRetList` into `List<SalesOrderLine>`, extracting motor/belt codes from item names
3. **Quantity Expansion**: FrmMain expands line quantities into individual tag records (qty=3 becomes 3 separate OrderInfo rows)
4. **Access Storage**: `ORDERINFODAL` persists processed orders to the `OrderInfo` table in `usman.mdb`
5. **Report Generation**: `FrmCRViewer` loads Crystal Reports (`tag.rpt` or `TagWithQRCodes.rpt`), binds the DataSet, and renders printable labels

### Dual Database Pattern

- **QuickBooks** (via ODBC DSN "QuickBooks Data") — source of truth for sales orders
- **Access usman.mdb** (via OLE DB) — local cache for OrderInfo, Parts, and QrCodes tables; `|DataDirectory|` resolves to `%LocalAppData%\QBTag\` at runtime

### Layer Conventions

- **DAL classes** are ALL-CAPS (e.g., `SALESORDERLINEDAL`, `ORDERINFODAL`, `PARTSDAL`, `QRCODESDAL`)
- **Handler classes** are thin wrappers that instantiate a DAL and delegate (e.g., `OrderInfoHandler.GetOrders()` calls `new ORDERINFODAL().SelectOrders()`)
- **Model classes** use an inheritance chain: `OrderNumber` → `Motor` → `Belt`; separately `OrderNumber` → `Parts` → `OrderInfo` → `SalesLine` → `SalesOrderLine`

### Database Schema (Access usman.mdb)

```sql
-- Core tables
CREATE TABLE OrderInfo(OrderNumber TEXT(50), Motor TEXT(50), Belt TEXT(50), PartType TEXT(50), CopiedNo TEXT(50))
CREATE TABLE Parts(PartType TEXT(50))
CREATE TABLE tblProducts(ProductName TEXT(50), Quantity TEXT(50))
CREATE TABLE tblQrCode(Link COUNTER PRIMARY KEY, ProductNumber TEXT(50) NOT NULL, QrPhoto IMAGE NOT NULL)

-- View joining orders to QR codes
CREATE VIEW ViewOrderWithQRCode AS
SELECT OrderInfo.OrderNumber, OrderInfo.Motor, OrderInfo.Belt, OrderInfo.PartType, tblQrCode.Link, tblQrCode.QrPhoto
FROM OrderInfo INNER JOIN tblQrCode ON OrderInfo.PartType = tblQrCode.ProductNumber
```

Auto-creation: `FrmConfig.EnsureDatabaseExists()` creates the database and all tables/views on first run using ADOX.

### QuickBooks Session Management

`QBCommunication` is a singleton managing the QBFC12 `QBSessionManagerClass`. `Manager.ConnectToQB()` initializes the session with app name "ABANAKI" and XML version 9. The singleton handles connection retry with a 500ms wait on first failure.

### Crystal Reports

- `tag.rpt` is embedded as a resource in the QBTag assembly and also compiled into `tag.cs` (extends `ReportClass`)
- `TagWithQRCodes.rpt` is the alternate report with QR code images from `tblQrCode`
- Both reports accept parameters: FreePhone, FromWhere, Aero
- Standalone copies of both `.rpt` files are in `SupportingFiles/Reports/`
- Custom reports can be registered via `--add-report` CLI command (stored as `name|path` pairs in settings)

### Configuration

`QBTag/app.config` contains connection strings and user settings. A deployment copy exists at `SupportingFiles/Config/QBTag.exe.config`. Key settings:
- `QuickBooksDBConnectionString` — ODBC DSN connection to QuickBooks
- `usmanConnectionString` — OLE DB connection to Access database
- `MySettings` — QB data source name, user credentials, Access DB path

Settings are loaded via `MySettingsProperty.Settings` (singleton, auto-saved on app shutdown). `FrmConfig.ResolveDbPath()` expands `|DataDirectory|` to the actual filesystem path.

### Runtime File Paths

- **Database**: `%LocalAppData%\QBTag\usman.mdb` (default, configurable via `--set-db`)
- **Logs**: `%LocalAppData%\QBTag\Log\` (file-based rotation via `FileSplitter`, default 1MB per file)

### Logging

`Log.Add(message, header, showMessage)` writes to file-based logs with size-based rotation via `FileSplitter`. `LogQB` extends this with QB-specific error parsing from `IResponse` objects. The log viewer form (`frmReview`) is also available in-app.

### Key Entry Points

- **FrmMain** — main form; `btnExport_Click()` drives the full order-query-to-tag-print workflow
- **FrmCRViewer** — Crystal Reports viewer; `ShowTagReport()` and `ShowTagReportWithQRCodes()`
- **FrmConfig** — database connection configuration, part type management, and DB creation
- **CLI** — command-line diagnostics and configuration (bypasses GUI)

## CI/CD

Three GitHub Actions workflows (all run on `windows-latest`):

- **build.yml** — Triggered on push/PR to main. Restores, builds Release, uploads `QBTag/bin/Release/net40/` as artifact.
- **build-installer.yml** — Triggered on push/PR/manual. Builds Release, stages supporting files (reports, Product.xml, manifest), downloads .NET 4.0 installer, builds Inno Setup installer (`installer/QBTag.iss`).
- **release.yml** — Triggered on `v*` tag push. Sets AssemblyVersion from tag across all `AssemblyInfo.cs` files, builds installer + portable zip, creates GitHub Release with both artifacts.

## Versioning

Assembly versions are set manually in `Properties/AssemblyInfo.cs` for each project. The release workflow auto-patches these from the git tag (e.g., tag `v3.1.0` sets version `3.1.0.0`). `GenerateAssemblyInfo` is `False` in all `.csproj` files.
