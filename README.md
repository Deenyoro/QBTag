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

`dotnet build` alone cannot build the solution: two WinForms `.resx` files
contain serialized images, which only Visual Studio's (.NET Framework)
MSBuild can embed for a .NET Framework target. Use `msbuild` from Visual
Studio 2022 or the VS 2022 Build Tools.

## Building / Releases (GitLab CI)

CI/CD runs on GitLab only (`.gitlab-ci.yml`); the old GitHub Actions
workflows in `.github/` no longer run. Pipelines start on `v*` tags and when
run from the GitLab web UI or API, not on ordinary pushes.

| Job | Runner | What it does |
|---|---|---|
| `test` | Linux | `ci/check-sources.ps1` (solution projects, AssemblyInfo attributes, installer sources and committed prerequisites exist), stamps the release version on tag builds, then compiles all C# with `dotnet build` (the two `.resx` files skipped; a compile check only, nothing is published) |
| `build-windows` | Windows laptop | Visual Studio MSBuild Release build, `QBTag.exe --version` smoke run, Inno Setup installer and portable zip (job artifacts, 30 days) |
| `release` | Linux | tags / `RELEASE_VERSION` only: uploads the installer and zip to the project's Generic Package Registry and creates or updates the GitLab Release |

The Windows job sets up its own tools on first use under
`%ProgramData%\gitlab-runner-tools` (`ci/tools-windows.ps1`, no admin): the
.NET SDK 9.0.121, Inno Setup 6.7.3 and the .NET Framework 4.0 offline
installer, all pinned by SHA-256. It needs Visual Studio 2022 or the VS 2022
Build Tools (MSBuild 17.11 or newer) already installed on the runner machine,
which is a one-time admin install; the job stops with the install command if
it is missing.

To release: tag the commit `vX.Y.Z` (numbers only) and push the tag. The
pipeline writes `X.Y.Z.0` into every `AssemblyInfo.cs` for that build (the
committed files are not changed), checks that `QBTag.exe` reports it, and
publishes `QBTag-Setup-X.Y.Z.exe` and `QBTag-vX.Y.Z-portable.zip` to the
GitLab Release for the tag. To rebuild an existing release, run a pipeline on
the tag from the web UI with the variable `RELEASE_VERSION=vX.Y.Z`. Runs
without a tag build `0.0.0-<commit>` installers with the committed assembly
versions and publish nothing.

The installer bundles `installer/prereqs/qodbc.exe`, `qbsdk120.exe` and
`CRRedist2008_x86.msi` from the repository; the `test` job fails if any of
them is missing.

## Releases

Releases (installer and portable zip) are published on this project's
GitLab Releases page. Releases made before the move to GitLab CI were
published by GitHub Actions on the [GitHub Releases](https://github.com/Deenyoro/QBTag/releases) page.
