# QBTag

QuickBooks Sales Order Tag Printing application for Abanaki. Pulls sales orders from QuickBooks, generates product tags with QR codes, and prints them via Crystal Reports.

## Features

- QuickBooks integration via QBFC12 SDK
- Sales order lookup by order number, number range, or date range
- Product tag generation with QR codes
- Crystal Reports-based label printing
- ODBC database connectivity for order/parts management

## Projects

| Project | Description |
|---|---|
| **QBTag** | Main WinForms application |
| **QuickBooksDAL** | Data access layer (ODBC + QuickBooks SDK) |
| **QuickBooksHandler** | Business logic layer |
| **QuickBooksModel** | Data models (OrderInfo, Parts, SalesOrderLine, etc.) |
| **QBSalesOrder** | QuickBooks sales order queries |
| **QBHelpers** | QuickBooks communication, registration, and settings |
| **Logs** | Error logging and log file management |
| **Interop.QBFC12Lib** | QuickBooks SDK interop types |

## Requirements

- .NET Framework 4.0
- QuickBooks Desktop with QBFC12 SDK
- Crystal Reports Runtime
- Windows (x86)

## Build

Open `QBTag.sln` in Visual Studio 2022 or build from command line:

```
dotnet restore QBTag.sln
msbuild QBTag.sln -p:Configuration=Release
```

Output binaries will be in `QBTag/bin/Release/net40/`.

## Releases

Pre-built binaries are available on the [Releases](https://github.com/Deenyoro/QBTag/releases) page.
