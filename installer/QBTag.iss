#define MyAppName "QBTag"
#define MyAppVersion "2.5.1"
#define MyAppPublisher "Abanaki"
#define MyAppExeName "QBTag.exe"
#define BuildDir "..\QBTag\bin\Release\net40"

[Setup]
AppId={{F3B2C83A-26FF-45F0-A812-B58AC802494F}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
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

; Crystal Reports (bundled from NuGet — no separate runtime install needed)
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
Filename: "{app}\{#MyAppExeName}"; Description: "Launch {#MyAppName}"; Flags: nowait postinstall skipifsilent

[Code]
function IsDotNet40Installed(): Boolean;
var
  Release: Cardinal;
begin
  Result := RegQueryDWordValue(HKLM,
    'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full',
    'Release', Release);
end;

function InitializeSetup(): Boolean;
begin
  Result := True;
  if not IsDotNet40Installed() then
  begin
    MsgBox('{#MyAppName} requires .NET Framework 4.0 or later.' + #13#10 + #13#10 +
           'Please download and install it from:' + #13#10 +
           'https://dotnet.microsoft.com/download/dotnet-framework/net40',
           mbCriticalError, MB_OK);
    Result := False;
  end;
end;
