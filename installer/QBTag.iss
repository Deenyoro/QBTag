#define MyAppName "QBTag"
#ifndef MyAppVersion
  #define MyAppVersion "0.0.0"
#endif
#define MyAppPublisher "Abanaki"
#define MyAppExeName "QBTag.exe"
#define BuildDir "..\QBTag\bin\Release\net40"

[Setup]
AppId={{F3B2C83A-26FF-45F0-A812-B58AC802494F}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=output
OutputBaseFilename=QBTag-Setup-{#MyAppVersion}
SetupIconFile=..\QBTag\app.ico
UninstallDisplayIcon={app}\{#MyAppExeName}
Compression=lzma2/ultra64
SolidCompression=yes
WizardStyle=modern
PrivilegesRequired=admin
ArchitecturesAllowed=x86compatible
MinVersion=6.1sp1

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Files]
; .NET Framework 4.0 offline installer (bundled, silent install if needed)
Source: "..\installer\prereqs\dotNetFx40_Full_x86_x64.exe"; DestDir: "{tmp}"; Flags: ignoreversion deleteafterinstall; Check: not IsDotNet40Installed

; Main application
Source: "{#BuildDir}\QBTag.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\QBTag.exe.config"; DestDir: "{app}"; Flags: ignoreversion

; Application DLLs
Source: "{#BuildDir}\Interop.QBFC12Lib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\Logs.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\QBHelpers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\QBSalesOrder.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\QuickBooksDAL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\QuickBooksHandler.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\QuickBooksModel.dll"; DestDir: "{app}"; Flags: ignoreversion

; Crystal Reports managed DLLs (bundled from NuGet — no separate runtime needed)
Source: "{#BuildDir}\CrystalDecisions.CrystalReports.Engine.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\CrystalDecisions.Shared.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\CrystalDecisions.Windows.Forms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\CrystalDecisions.ReportSource.dll"; DestDir: "{app}"; Flags: ignoreversion

; Report templates
Source: "{#BuildDir}\tag.rpt"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\TagWithQRCodes.rpt"; DestDir: "{app}"; Flags: ignoreversion

; Config (don't overwrite user config on upgrade)
Source: "{#BuildDir}\Product.xml"; DestDir: "{app}"; Flags: onlyifdoesntexist
Source: "{#BuildDir}\QBTag.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\Uninstall {#MyAppName}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
; Install .NET Framework 4.0 silently if needed
Filename: "{tmp}\dotNetFx40_Full_x86_x64.exe"; Parameters: "/q /norestart"; StatusMsg: "Installing .NET Framework 4.0 (this may take a few minutes)..."; Flags: waituntilterminated; Check: not IsDotNet40Installed

; Launch app
Filename: "{app}\{#MyAppExeName}"; Description: "Launch {#MyAppName}"; Flags: nowait postinstall skipifsilent

[Code]
function IsDotNet40Installed(): Boolean;
var
  Release: Cardinal;
  Success: Boolean;
begin
  Success := RegQueryDWordValue(HKLM,
    'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full',
    'Release', Release);
  if not Success then
    Success := RegValueExists(HKLM,
      'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full',
      'Install');
  Result := Success;
end;
