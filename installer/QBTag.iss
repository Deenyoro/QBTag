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
DisableDirPage=no
DisableProgramGroupPage=yes
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

; Crystal Reports managed DLLs (bundled from NuGet)
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

[Dirs]
Name: "{localappdata}\QBTag\Log"

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\Uninstall {#MyAppName}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
; Install .NET Framework 4.0 silently if needed
Filename: "{tmp}\dotNetFx40_Full_x86_x64.exe"; Parameters: "/q /norestart"; StatusMsg: "Installing .NET Framework 4.0 (this may take a few minutes)..."; Flags: waituntilterminated; Check: not IsDotNet40Installed

; Create database if it doesn't exist at the chosen path
Filename: "{app}\{#MyAppExeName}"; Parameters: "--init-db ""{code:GetDbPath}"""; StatusMsg: "Initializing tag database..."; Flags: runhidden waituntilterminated

; Set the database path in app config
Filename: "{app}\{#MyAppExeName}"; Parameters: "--set-db ""{code:GetDbPath}"""; StatusMsg: "Configuring database path..."; Flags: runhidden waituntilterminated

; Launch app
Filename: "{app}\{#MyAppExeName}"; Description: "Launch {#MyAppName}"; Flags: nowait postinstall skipifsilent

[Code]
var
  DbPage: TWizardPage;
  DbPathEdit: TNewEdit;
  DbBrowseBtn: TNewButton;

procedure DbBrowseClick(Sender: TObject);
var
  Path: String;
begin
  Path := DbPathEdit.Text;
  if BrowseForFolder('Select folder for the tag database:', Path, False) then
    DbPathEdit.Text := Path + '\usman.mdb';
end;

procedure InitializeWizard;
var
  Lbl: TNewStaticText;
begin
  DbPage := CreateCustomPage(wpSelectDir,
    'Tag Database Location',
    'Where is the tag database (usman.mdb)?');

  Lbl := TNewStaticText.Create(DbPage);
  Lbl.Parent := DbPage.Surface;
  Lbl.Caption := 'Enter the full path to an existing usman.mdb file, or select a folder' + #13#10 +
    'to create a new database. Supports local and network paths.';
  Lbl.Top := 0;
  Lbl.Left := 0;
  Lbl.Width := DbPage.SurfaceWidth;
  Lbl.AutoSize := True;
  Lbl.WordWrap := True;

  DbPathEdit := TNewEdit.Create(DbPage);
  DbPathEdit.Parent := DbPage.Surface;
  DbPathEdit.Top := Lbl.Top + Lbl.Height + 16;
  DbPathEdit.Left := 0;
  DbPathEdit.Width := DbPage.SurfaceWidth - 90;
  DbPathEdit.Text := ExpandConstant('{localappdata}\QBTag\usman.mdb');

  DbBrowseBtn := TNewButton.Create(DbPage);
  DbBrowseBtn.Parent := DbPage.Surface;
  DbBrowseBtn.Top := DbPathEdit.Top - 1;
  DbBrowseBtn.Left := DbPathEdit.Left + DbPathEdit.Width + 8;
  DbBrowseBtn.Width := 78;
  DbBrowseBtn.Height := DbPathEdit.Height + 2;
  DbBrowseBtn.Caption := 'Browse...';
  DbBrowseBtn.OnClick := @DbBrowseClick;
end;

function GetDbPath(Param: String): String;
begin
  Result := DbPathEdit.Text;
end;

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
