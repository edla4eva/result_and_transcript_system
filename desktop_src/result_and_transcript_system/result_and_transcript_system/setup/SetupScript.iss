; -- ResultandTrascriptProcessingSystem.iss --
; Setup script

[Setup]
AppName=Result and Trascript Processing System
AppVersion=1.0
DefaultDirName={pf}\ResultandTrascriptProcessingSystem
DefaultGroupName=ResultandTrascriptProcessingSystem
UninstallDisplayIcon={app}\ResultandTrascriptProcessingSystem.exe
Compression=lzma2
SolidCompression=yes
OutputDir="setup for ResultandTrascriptProcessingSystem\"

;my custom perl code/directive
[Code]
#define Mydir "ResultandTrascriptProcessingSystem"
[InstallDelete]
Type: files; Name: "{app}\ResultandTrascriptProcessingSystem.exe"

[Files]
;main program
Source: "..\bin\debug\result_and_transcript_system.exe"; DestDir: "{app}"
Source: "..\bin\debug\result_and_transcript_system.exe.config"; DestDir: "{app}"
;dlls
Source: "..\bin\debug\ExcelDataReader.DataSet.dll"; DestDir: "{app}"
Source: "..\bin\debug\ExcelDataReader.dll"; DestDir: "{app}"

;pdb and xml todo
Source: "..\bin\debug\ExcelDataReader.DataSet.pdb"; DestDir: "{app}"
Source: "..\bin\debug\ExcelDataReader.pdb"; DestDir: "{app}"

Source: "..\bin\debug\ExcelDataReader.DataSet.xml"; DestDir: "{app}"


;samples
Source: "..\bin\debug\samples\broadsheet.xlsx"; DestDir: "{app}\bibles"

;templates
Source: "..\bin\debug\templates\result.xltx"; DestDir: "{userdocs}\{#Mydir}\templates"
Source: "..\bin\debug\templates\result.xltx"; DestDir: "{userdocs}\{#Mydir}\templates"



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


[Icons]
Name: "{group}\ResultandTrascriptProcessingSystem"; Filename: "{app}\result_and_transcript_system.exe"
