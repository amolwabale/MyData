
#define MyAppName "Database Backup Utility"
#define MyAppId "A682D6D4-584D-4240-B66D-F503059A7E64"
#define OutputSetupName "Database_Backup_Utility"
#define MyAppVersion GetFileVersion("..\..\1.Database.Backup.FrontEnd\Database.Backup.Ui\bin\Release\Database.Backup.Ui.exe")
#define MyAppPublisher "DBU"
#define MyAppURL "https://amolwabale.blogspot.in"
#define MyDateTime GetDateTimeString('[ dd/mmmm/yyyy ] [ h:n:s AM/PM ]', '-', ':');
#define CurrentYear GetDateTimeString('yyyy','','');

;PATH VARIABLES
#define SourceFrontEnd "..\..\1.Database.Backup.FrontEnd\Database.Backup.Ui\bin\Release\*"
#define SourceBackEnd "..\..\2.Database.Backup.BackEnd\Database.Backup.Service\bin\Release\*"


#define BackEndExe "Applications\Database.Backup.Service\Database.Backup.Service.exe"
#define FrontEndExe "Applications\Database.Backup.Ui\Database.Backup.Ui.exe"

#define IconPath "Applications\Database.Backup.Ui\Resources\DatabaseBackupUtility.ico"

#define DestDirFrontEnd "Applications\Database.Backup.Ui"
#define DestDirBackEnd "Applications\Database.Backup.Service"

#define ExcludeFrontEnd "*.log,\Logs,*.pdb"
#define ExcludeBackEnd "*.log,\Logs,*.pdb"
;*********************************************************************************************************************************************************************
[Setup] 

AppName={#MyAppName}
AppId={#MyAppId}
AppVersion={#MyAppVersion}
VersionInfoVersion={#MyAppVersion}
VersionInfoDescription="SQL Database Backup Utility - Amol Wabale"
VersionInfoCopyright="Open Source"
AppPublisherURL={#MyAppURL}
AppPublisher={#MyAppPublisher}
UninstallDisplayName={#MyAppName}
UninstallDisplayIcon={app}\{#DestDirFrontEnd}\Resources\DatabaseBackupUtility.ico
OutputBaseFilename={#OutputSetupName}_v{#MyAppVersion}
DefaultDirName={pf32}\{#MyAppName}
DefaultGroupName={#MyAppName}
//Logs setup activity into temp folder with title format e.g. "Setup Log 2016-10-25 #001.txt" format "Setup Log Date #Sr.no.txt"
SetupLogging =yes
Compression=lzma2
SolidCompression=yes
OutputDir=Output
PrivilegesRequired=admin
DisableProgramGroupPage=true
DisableStartupPrompt=true
;Doesnt show dialog to close application, stops the service, doesnt restart after finishing the setup
CloseApplications=no   

;*********************************************************************************************************************************************************************
[Files]

Source: {#SourceFrontEnd}; Excludes:"{#ExcludeFrontEnd}"; DestDir: "{app}\{#DestDirFrontEnd}"; Flags: ignoreversion recursesubdirs skipifsourcedoesntexist

Source: {#SourceBackEnd}; Excludes:"{#ExcludeBackEnd}"; DestDir: "{app}\{#DestDirBackEnd}"; Flags: ignoreversion recursesubdirs createallsubdirs; BeforeInstall: TaskKill('Database.Backup.Service.exe')

;*********************************************************************************************************************************************************************
[run]

Filename: "{app}\{#BackEndExe}"; Parameters: "-i" ; Flags: runhidden

;*********************************************************************************************************************************************************************
[UninstallRun]

Filename: "{app}\{#BackEndExe}"; Parameters: "-u" ; Flags: runhidden

;*********************************************************************************************************************************************************************
[UninstallDelete]
Type: filesandordirs; Name: "{app}"

;*********************************************************************************************************************************************************************
[InstallDelete]
Type: filesandordirs; Name: "{app}"

[Icons]
Name: "{commondesktop}\{#MyAppName}"; Filename: {app}\{#FrontEndExe}; WorkingDir: "{app}"; IconFilename: {app}\{#IconPath}

;*********************************************************************************************************************************************************************
[Registry]
Root: HKLM; Subkey: "Software\{#MyAppPublisher}"; Flags: uninsdeletekeyifempty noerror
Root: HKLM; Subkey: "Software\{#MyAppPublisher}\{#MyAppName}"; ValueType: string; ValueName: "ProductName"; ValueData: {#MyAppName}; Flags: uninsdeletekey noerror
Root: HKLM; Subkey: "Software\{#MyAppPublisher}\{#MyAppName}"; ValueType: string; ValueName: "Version"; ValueData: {#MyAppVersion}; Flags: uninsdeletekey noerror
Root: HKLM; Subkey: "Software\{#MyAppPublisher}\{#MyAppName}"; ValueType: string; ValueName: "InstalledDate"; ValueData: {#MyDateTime}; Flags: uninsdeletekey noerror
Root: HKLM; Subkey: "Software\{#MyAppPublisher}\{#MyAppName}"; ValueType: string; ValueName: "InstalledPath"; ValueData: {app}; Flags: uninsdeletekey noerror
Root: HKLM; Subkey: "Software\{#MyAppPublisher}\{#MyAppName}"; ValueType: string; ValueName: "Manufacturer"; ValueData: {#MyAppPublisher}; Flags: uninsdeletekey noerror
Root: HKLM; Subkey: "Software\{#MyAppPublisher}\{#MyAppName}"; ValueType: string; ValueName: "Support"; ValueData: {#MyAppURL}; Flags: uninsdeletekey noerror

;*********************************************************************************************************************************************************************
[Code]

//Prevent downgrade to lower version
function InitializeSetup: Boolean;
var Version: String;
begin
  if RegValueExists(HKEY_LOCAL_MACHINE,'Software\Microsoft\Windows\CurrentVersion\Uninstall\{#MyAppId}_is1', 'DisplayVersion') then
    begin
      RegQueryStringValue(HKEY_LOCAL_MACHINE,'Software\Microsoft\Windows\CurrentVersion\Uninstall\{#MyAppId}_is1', 'DisplayVersion', Version);
      if Version > '{#MyAppVersion}' then
        begin
          MsgBox('Cannot downgrade to lower version. Newer version already exist :'+ #13#10 +'{#MyAppName}_v' + Version, mbInformation, MB_OK);
          Result := False;
        end
      else
        begin
          Result := True;
        end
    end
  else
    begin
      Result := True;
    end
end;

//During upgrade of file is used by other process, it kills the process.
procedure TaskKill(FileName: String);
var
  ResultCode: Integer;
begin
    Exec(ExpandConstant('taskkill.exe'), '/f /im ' + '"' + FileName + '"', '', SW_HIDE,
     ewWaitUntilTerminated, ResultCode);
end;


