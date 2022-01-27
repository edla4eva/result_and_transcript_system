; -- ResultandTrascriptProcessingSystem.iss --
; Setup script
;my custom perl code/directive
[Code]
#define MyAppName "RTPS Result Software"
#define MyAppVersion "1.0.1B5"
#define MyAppPublisher "Edoghogho Olaye"
#define MyAppURL "https://www.edla4eva.github.io/guide.html"
#define MyAppExeName "RTPS_Result_Setup_1_0_1_Beta_6"
#define MyDir "RTPS Result Soft"

[Setup]
PrivilegesRequired=admin
AppName={#MyAppName}
OutputBaseFilename={#MyAppExeName}
AppVersion={#MyAppVersion}
DefaultDirName={commonpf}\{#MyDir}
DefaultGroupName={#MyDir}
UninstallDisplayIcon={app}\{#MyAppExeName}
Compression=lzma2
SolidCompression=yes
OutputDir="RTPS Result Soft Setup\"

AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}

[Icons]
Name: "{group}\RTPS Result Software"; Filename: "{app}\result_and_transcript_system.exe"
;this is what shows up in windows start-programs menu


[InstallDelete]
Type: files; Name: {app}\{#MyAppExeName}

[Files]
;main program
Source: "..\bin\debug\result_and_transcript_system.exe"; DestDir: "{app}"
Source: "..\bin\debug\result_and_transcript_system.exe.config"; DestDir: "{app}"
;Database
;DONT OVERWRITE USER'S DATA Source: "..\bin\debug\db\db.mdb"; DestDir: "{app}\db"

;dlls

 ;help files
Source: "..\bin\debug\help\guide.html"; DestDir: "{app}\help\guide.html"
Source: "..\bin\debug\help\js\bootstrap.min.js"; DestDir: "{app}\help\js\bootstrap.min.js"


;samples
Source: "..\bin\debug\samples\sample_broadsheet.xlsx"; DestDir: "{app}\samples"
Source: "..\bin\debug\samples\Sample_result.xlsx"; DestDir: "{app}\samples"
;Source: "..\bin\debug\samples\sample_GPA_DMI.xlsx"; DestDir: "{userdocs}\{#Mydir}\samples"
Source: "..\bin\debug\samples\Students_CCT_1_2018_2019.xlsx"; DestDir: "{userdocs}\{#Mydir}\samples"
Source: "..\bin\debug\samples\sample_inputs\Sample Registration Inputs\Registration_data_for_RTPS_2018_2019.xlsx"; DestDir: "{userdocs}\{#Mydir}\samples"

;photos
;templates
Source: "..\bin\debug\templates\result.xltx"; DestDir: "{userdocs}\{#Mydir}\templates"
Source: "..\bin\debug\templates\courses.xltx"; DestDir: "{userdocs}\{#Mydir}\templates"
Source: "..\bin\debug\templates\students.xltx"; DestDir: "{userdocs}\{#Mydir}\templates"
Source: "..\bin\debug\templates\registration.xltx"; DestDir: "{userdocs}\{#Mydir}\templates"

;images
Source: "..\bin\debug\photos\ENG1503585.jpg"; DestDir: "{userdocs}\{#Mydir}\photos"
Source: "..\bin\debug\photos\photo_female.jpg"; DestDir: "{userdocs}\{#Mydir}\photos"
Source: "..\bin\debug\scans\result_2018_2019_ecp281.jpg"; DestDir: "{userdocs}\{#Mydir}\scans"


;Save templates in prog path as backup
;templates
Source: "..\bin\debug\templates\result.xltx"; DestDir: "{app}\templates"
Source: "..\bin\debug\templates\broadsheet.xltx"; DestDir: "{app}\templates"
Source: "..\bin\debug\templates\broadsheet.xlsm"; DestDir: "{app}\templates"
Source: "..\bin\debug\templates\broadsheet_plain.xlsx"; DestDir: "{app}\templates"
Source: "..\bin\debug\templates\broadsheet - Copy3.xlsm"; DestDir: "{app}\templates"
Source: "..\bin\debug\templates\gpa.xltx"; DestDir: "{app}\templates"
Source: "..\bin\debug\templates\senate.xltx"; DestDir: "{app}\templates"
 Source: "..\bin\debug\templates\courses.xltx"; DestDir: "{app}\templates"
Source: "..\bin\debug\templates\students.xltx"; DestDir: "{app}\templates"
Source: "..\bin\debug\templates\registration.xltx"; DestDir: "{app}\templates"

;save copy in prog path
Source: "..\bin\debug\samples\sample_broadsheet.xlsm"; DestDir: "{app}\samples"
;Source: "..\bin\debug\samples\sample_result.xltx"; DestDir: "{app}\samples"
;broadsheets
Source: "..\bin\debug\broadsheets\broadsheet_saved.xlsm"; DestDir: "{userdocs}\{#Mydir}\broadsheets"
Source: "..\bin\debug\results\sample_result.xlsx"; DestDir: "{userdocs}\{#Mydir}\results"

;{usercf}
;The path to the current user's Common Files directory. 
;Only Windows 7 and later supports {usercf}; if used on previous Windows versions, 
;it will translate to the same directory as {localappdata}\Programs\Common.

;---------------------------------------------------
;lets put some stuff here so that they are writable
;{userdocs} & {commondocs}
;The path to the My Documents folder.

;{userappdata} & {commonappdata}
;The path to the Application Data folder.

;{localappdata}
;The path to the local (nonroaming) Application Data folder.
;

;Test thumbnails
;Source: "..\bin\debug\images\thumbnails\hd-01.jpg"; DestDir: "{userdocs}\images\thumbnails"


