# Changelog

All notable changes to QBTag are recorded here. Versions match the `vX.Y.Z`
git tags; releases before 3.2.16 were published on GitHub and have no
entries here.

## [3.2.16] - 2026-09-24

### Added
- A `test` stage runs on every GitLab pipeline before anything is built: in
  the `mcr.microsoft.com/dotnet/sdk:9.0` image it runs `ci/check-sources.ps1`,
  which checks the project and installer sources (the Windows build and
  installer jobs only start after it passes).

### Changed
- Builds and releases run on GitLab CI (`.gitlab-ci.yml`); the GitHub
  Actions workflows no longer run. Tag pipelines build with Visual Studio's
  MSBuild on the Windows runner, check `QBTag.exe --version`, build the Inno
  Setup installer and portable zip, and publish them with a `SHA256SUMS.txt`
  on this project's GitLab Releases page.
- The setup (about 175 MB with its bundled prerequisites) is uploaded to the
  GitLab package registry instead of being kept as a job artifact, which is
  too large for GitLab's default limit. The build checks each bundled
  prerequisite is present before building the installer, and release notes
  come from this changelog.
- Helper scripts in `ci/` install the pinned build tools on the Windows
  runner, stamp the release version, check the sources and publish the files.
- The README explains how to build (Visual Studio's MSBuild only), what each
  pipeline job does, what the Windows runner needs and how to cut a release.
- The committed assembly versions are now 3.2.16.0 (they had stayed at
  3.0.3.0; release builds were already stamped from the tag).

No application changes.
