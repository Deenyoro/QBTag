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
| `test` | Linux | `ci/check-sources.ps1` (solution projects, AssemblyInfo attributes, installer sources and committed prerequisites exist); on tag builds, stamps the release version and checks that `CHANGELOG.md` has an entry for it; then compiles all C# with `dotnet build` (the two `.resx` files skipped; a compile check only, nothing is published) |
| `build-windows` | Windows laptop | Visual Studio MSBuild Release build, `QBTag.exe` version check, Inno Setup installer (each bundled prerequisite checked first), portable zip and `SHA256SUMS.txt`. On tag builds it uploads all three to the project's Generic Package Registry |
| `release` | Linux | tags / `RELEASE_VERSION` only: creates or updates the GitLab Release for the tag, with links to the uploaded files and the version's `CHANGELOG.md` entry as notes |

The installer is about 175 MB because it bundles the prerequisite
installers. That is over GitLab's default 100 MB job artifact limit, so it
is not kept as a job artifact: only tag builds keep it, in the package
registry. The job artifacts (90 days) are the portable zip and
`SHA256SUMS.txt`. Untagged runs build and check the installer but do not
keep it.

The Windows job sets up its own tools on first use under
`%ProgramData%\gitlab-runner-tools` (`ci/tools-windows.ps1`, no admin): the
.NET SDK 9.0.121, Inno Setup 6.7.3 and the .NET Framework 4.0 offline
installer, all pinned by SHA-256. It needs Visual Studio 2022 or the VS 2022
Build Tools (MSBuild 17.11 or newer, workload `ManagedDesktopBuildTools`)
already installed on the runner machine. That is a one-time admin install;
the job stops with the install command if it is missing.

To release:

1. Bump the version: add a `## [X.Y.Z] - <date>` entry to `CHANGELOG.md` and
   set `X.Y.Z.0` in the `AssemblyInfo.cs` files (`pwsh ci/set-version.ps1
   -Version X.Y.Z` does all of them).
2. Tag the commit `vX.Y.Z` (numbers only) and push the tag.

The pipeline stamps `X.Y.Z.0` into every `AssemblyInfo.cs` for that build,
checks that `QBTag.exe` carries it, and publishes `QBTag-Setup-X.Y.Z.exe`,
`QBTag-vX.Y.Z-portable.zip` and `SHA256SUMS.txt` to the GitLab Release for
the tag. If a tag pipeline failed before it uploaded anything (for example
the Windows runner was offline), run a pipeline on the tag from the web UI
with the variable `RELEASE_VERSION=vX.Y.Z`. Files that are already
published are never uploaded again (builds are not byte-identical, and the
release is mirrored to GitHub); release a new patch version instead.
Runs without a tag build `0.0.0-<commit>` with the committed assembly
versions and publish nothing.

The installer bundles `installer/prereqs/qodbc.exe`, `qbsdk120.exe` and
`CRRedist2008_x86.msi` from the repository; the `test` and `build-windows`
jobs fail if any of them is missing.

## Releases

Releases (installer and portable zip) are published on this project's
GitLab Releases page. Releases made before the move to GitLab CI were
published by GitHub Actions on the [GitHub Releases](https://github.com/Deenyoro/QBTag/releases) page.
