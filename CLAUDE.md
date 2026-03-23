# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Overview

QBTag v3.0.0 is a .NET Framework 4.0 WinForms application for Abanaki that prints product tags from QuickBooks sales orders. It queries QuickBooks Desktop via the QBFC12 SDK, stores processed order data in an Access database (usman.mdb), and generates printable labels via Crystal Reports with optional QR codes.

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

## Architecture

### Dependency Graph

```
QBTag (WinForms UI)
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
- **Access usman.mdb** (via OLE DB) — local cache for OrderInfo, Parts, and QrCodes tables; `|DataDirectory|` resolves to the app's startup path

### Layer Conventions

- **DAL classes** are ALL-CAPS (e.g., `SALESORDERLINEDAL`, `ORDERINFODAL`, `PARTSDAL`, `QRCODESDAL`)
- **Handler classes** are thin wrappers that instantiate a DAL and delegate (e.g., `OrderInfoHandler.GetOrders()` calls `new ORDERINFODAL().SelectOrders()`)
- **Model classes** use an inheritance chain: `OrderNumber` → `Motor` → `Belt` → `Parts` → `OrderInfo`; `SalesLine` → `SalesOrderLine`

### QuickBooks Session Management

`QBCommunication` is a singleton managing the QBFC12 `QBSessionManagerClass`. `Manager.ConnectToQB()` in QBSalesOrder initializes the session with app name "ABANAKI". The singleton handles connection retry with a 500ms wait on first failure.

### Crystal Reports

- `tag.rpt` is embedded as a resource in the QBTag assembly and also compiled into `tag.cs` (extends `ReportClass`)
- `TagWithQRCodes.rpt` is the alternate report with QR code images from `tblQrCode`
- Both reports accept parameters: FreePhone, FromWhere, Aero
- Standalone copies of both `.rpt` files are in `SupportingFiles/Reports/`

### Configuration

`QBTag/app.config` contains connection strings and user settings. A deployment copy exists at `SupportingFiles/Config/QBTag.exe.config`. Key settings:
- `QuickBooksDBConnectionString` — ODBC DSN connection to QuickBooks
- `usmanConnectionString` — OLE DB connection to Access database
- `MySettings` — QB data source name, user credentials, Access DB path

### Logging

`Log.Add(message, header, showMessage)` writes to file-based logs with size-based rotation via `FileSplitter`. `LogQB` extends this with QB-specific error parsing from `IResponse` objects.

### Key Entry Points

- **FrmMain** — main form; `btnExport_Click()` drives the full order-query-to-tag-print workflow
- **FrmCRViewer** — Crystal Reports viewer; `ShowTagReport()` and `ShowTagReportWithQRCodes()`
- **FrmConfig** — database connection configuration and part type management
