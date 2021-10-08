; -- ResultandTrascriptProcessingSystem.iss --
; Setup script

[Setup]
AppName=Result and Trascript Processing System
AppVersion=1.0
DefaultDirName={commonpf}\ResultandTrascriptProcessingSystem
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
;Database
Source: "..\bin\debug\db\db.mdb"; DestDir: "{app}\db"

;dlls
Source: "..\bin\debug\ExcelDataReader.DataSet.dll"; DestDir: "{app}"
Source: "..\bin\debug\ExcelDataReader.dll"; DestDir: "{app}"
Source: "..\bin\debug\Excel.Helper.dll"; DestDir: "{app}"
Source: "..\bin\debug\NPOI.dll"; DestDir: "{app}"
Source: "..\bin\debug\Excel.Helper.dll"; DestDir: "{app}"
Source: "..\bin\debug\NPOI.dll"; DestDir: "{app}"
Source: "..\bin\debug\NPOI.OOXML.dll"; DestDir: "{app}"
Source: "..\bin\debug\NPOI.OpenXml4Net.dll"; DestDir: "{app}"

Source: "..\bin\debug\NPOI.OpenXmlFormats.dll"; DestDir: "{app}"
Source: "..\bin\debug\MySql.Data.dll"; DestDir: "{app}"

;pdb and xml todo
Source: "..\bin\debug\ExcelDataReader.DataSet.pdb"; DestDir: "{app}"
Source: "..\bin\debug\ExcelDataReader.pdb"; DestDir: "{app}"

Source: "..\bin\debug\ExcelDataReader.DataSet.xml"; DestDir: "{app}"
Source: "..\bin\debug\Excel.Helper.xml"; DestDir: "{app}"
Source: "..\bin\debug\ExcelDataReader.xml"; DestDir: "{app}"
Source: "..\bin\debug\NPOI.OOXML.xml"; DestDir: "{app}"
Source: "..\bin\debug\NPOI.xml"; DestDir: "{app}"


;samples
Source: "..\bin\debug\samples\broadsheet.xlsx"; DestDir: "{app}\samples"
Source: "..\bin\debug\samples\result.xlsx"; DestDir: "{app}\samples"
Source: "..\bin\debug\samples\broadsheet.xlsx"; DestDir: "{userdocs}\{#Mydir}\samples"
Source: "..\bin\debug\samples\result.xlsx"; DestDir: "{userdocs}\{#Mydir}\samples"



;templates
Source: "..\bin\debug\templates\result.xltx"; DestDir: "{userdocs}\{#Mydir}\templates"
Source: "..\bin\debug\templates\broadsheet.xltx"; DestDir: "{userdocs}\{#Mydir}\templates"
Source: "..\bin\debug\templates\broadsheet.xlsm"; DestDir: "{userdocs}\{#Mydir}\templates"
Source: "..\bin\debug\templates\broadsheet_plain.xlsx"; DestDir: "{userdocs}\{#Mydir}\templates"
Source: "..\bin\debug\templates\broadsheet - Copy3.xlsm"; DestDir: "{userdocs}\{#Mydir}\templates"
;save copy in prog path
Source: "..\bin\debug\samples\sample_broadsheet.xlsm"; DestDir: "{app}\samples"
Source: "..\bin\debug\samples\sample_result.xltx"; DestDir: "{app}\samples"
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


[Icons]
Name: "{group}\ResultandTrascriptProcessingSystem"; Filename: "{app}\result_and_transcript_system.exe"
