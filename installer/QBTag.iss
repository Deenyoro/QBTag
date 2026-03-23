#define MyAppName "QBTag"
#define MyAppVersion "3.0.0"
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

; Crystal Reports (bundled managed DLLs from NuGet)
Source: "{#BuildDir}\CrystalDecisions.CrystalReports.Engine.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\CrystalDecisions.Shared.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\CrystalDecisions.Windows.Forms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\CrystalDecisions.ReportSource.dll"; DestDir: "{app}"; Flags: ignoreversion

; Crystal Reports Runtime MSI (silent install during setup)
Source: "..\installer\prereqs\CRRuntime_32bit_13_0_35.msi"; DestDir: "{tmp}"; Flags: ignoreversion deleteafterinstall; Check: not IsCRRuntimeInstalled

; Report templates
Source: "{#BuildDir}\tag.rpt"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#BuildDir}\TagWithQRCodes.rpt"; DestDir: "{app}"; Flags: ignoreversion

; Config (don't overwrite user config on upgrade)
Source: "{#BuildDir}\Product.xml"; DestDir: "{app}"; Flags: onlyifdoesntexist
Source: "{#BuildDir}\QBTag.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion

; .NET Framework 4.0 offline installer (silent install during setup)
Source: "..\installer\prereqs\dotNetFx40_Full_x86_x64.exe"; DestDir: "{tmp}"; Flags: ignoreversion deleteafterinstall; Check: not IsDotNet40Installed

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\Uninstall {#MyAppName}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
; Install .NET Framework 4.0 silently if needed
Filename: "{tmp}\dotNetFx40_Full_x86_x64.exe"; Parameters: "/q /norestart"; StatusMsg: "Installing .NET Framework 4.0..."; Flags: waituntilterminated; Check: not IsDotNet40Installed

; Install Crystal Reports Runtime silently if needed
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\CRRuntime_32bit_13_0_35.msi"" /qn /norestart"; StatusMsg: "Installing Crystal Reports Runtime..."; Flags: waituntilterminated; Check: not IsCRRuntimeInstalled

; Launch app after install
Filename: "{app}\{#MyAppExeName}"; Description: "Launch {#MyAppName}"; Flags: nowait postinstall skipifsilent

[Code]
function IsDotNet40Installed(): Boolean;
var
  Release: Cardinal;
  Success: Boolean;
begin
  // Check for .NET 4.0 Full profile
  Success := RegQueryDWordValue(HKLM,
    'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full',
    'Release', Release);
  if not Success then
    // Also check the older key (pre-4.5)
    Success := RegValueExists(HKLM,
      'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full',
      'Install');
  Result := Success;
end;

function IsCRRuntimeInstalled(): Boolean;
var
  Dummy: String;
begin
  // Check for Crystal Reports Runtime 13.0 (32-bit)
  Result := RegQueryStringValue(HKLM,
    'SOFTWARE\SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Crystal Reports',
    'CRRuntime', Dummy);
  if not Result then
    // Also check WOW6432 node
    Result := RegQueryStringValue(HKLM,
      'SOFTWARE\WOW6432Node\SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Crystal Reports',
      'CRRuntime', Dummy);
  if not Result then
    // Fallback: check if the main CR assembly is in GAC
    Result := RegKeyExists(HKLM,
      'SOFTWARE\Classes\Installer\Assemblies\Global\CrystalDecisions.CrystalReports.Engine');
end;
