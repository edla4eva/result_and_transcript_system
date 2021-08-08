; When deploying an installation that is an "update" (or "add-on") to an existing installation, you probably want 
; the following criteria to be met:

;    1. The update must be installed to the same directory as the original application.
;    2. Any new files installed by the update must be removed when the original application is uninstalled.
;    3. The update should not create a new entry in the Add/Remove Programs list, or alter the original application's entry. Nor should the application name displayed by the uninstaller change.

;1 and 2 may be achieved by giving your update installation the same AppId setting as the original application. 
;(If you never set AppId in the original application, then set AppId to the value of AppName used in the original 
;application.) This, when combined with UsePreviousAppDir=yes (the default setting), will cause the update 
;installation to default to the same directory as the original application, and share the same uninstall log file 
;(unins???.dat).

;3 may be achieved by setting CreateUninstallRegKey=no and UpdateUninstallLogAppName=no.

[Setup]
AppName=Heritage Media  Slide Plus
AppVersion=1.0
DefaultDirName={pf}\HeritageMediaSlidePlus
DefaultGroupName=HeritageMediaSlidePlus
UninstallDisplayIcon={app}\HeriageMediaSlidePlus.exe
Compression=lzma2
SolidCompression=yes
OutputDir="setup for HeriageMediaSlidePlus\"
;updater commands
AppId=myAppID20200524eResult 
UsePreviousAppDir=yes
CreateUninstallRegKey=no
UpdateUninstallLogAppName=no
;we need to update silently sometimes

;my custom perl code/directive
[Code]
#define Mydir "HeritageMediaSlidePlus"
[InstallDelete]
Type: files; Name: "{app}\HeriageMediaSlidePlus.exe"

[Files]
;main program
Source: "..\bin\debug\HeriageMediaSlidePlus.exe"; DestDir: "{app}"
Source: "..\bin\debug\HeriageMediaSlidePlus.exe.config"; DestDir: "{app}"
;dlls
Source: "..\bin\debug\HeritageMediaClassLibrary.dll"; DestDir: "{app}"
Source: "..\bin\debug\RapChatLib.dll"; DestDir: "{app}"
;songs
Source: "..\bin\debug\lyrics\songs.txt"; DestDir: "{userdocs}\{#Mydir}\lyrics"
Source: "..\bin\debug\lyrics\A wonderful Saviour.txt"; DestDir: "{userdocs}\{#Mydir}\lyrics"
Source: "..\bin\debug\lyrics\searchSong.txt"; DestDir: "{userdocs}\{#Mydir}\lyrics"

;services 
Source: "..\bin\debug\service\Genesis 1.1 (KJV).txt"; DestDir: "{userdocs}\{#Mydir}\service"
Source: "..\bin\debug\service\A wonderful Saviour.txt"; DestDir: "{userdocs}\{#Mydir}\service"

;bibles
Source: "..\bin\debug\bibles\KJV.mdb"; DestDir: "{app}\bibles"
Source: "..\bin\debug\bibles\ASV.mdb"; DestDir: "{app}\bibles"
Source: "..\bin\debug\bibles\RSV.mdb"; DestDir: "{app}\bibles"
Source: "..\bin\debug\bibles\BBE.mdb"; DestDir: "{app}\bibles"

;images (C:\.....\My Documents\Heritage....\
Source: "..\bin\debug\images\hd-01.jpg"; DestDir: "{userdocs}\{#Mydir}\images"
Source: "..\bin\debug\images\HD1920-856.jpg"; DestDir: "{userdocs}\{#Mydir}\images"
Source: "..\bin\debug\images\HD1366x720.jpg"; DestDir: "{userdocs}\{#Mydir}\images"
Source: "..\bin\debug\images\HD1920-2.jpg"; DestDir: "{userdocs}\{#Mydir}\images"

;preview
Source: "..\bin\debug\images\HD-01.jpg"; DestDir: "{userdocs}\{#Mydir}\images\preview"

;thumbnails
Source: "..\bin\debug\images\thumbnails\hd-01.jpg"; DestDir: "{userdocs}\{#Mydir}\images\thumbnails"
Source: "..\bin\debug\images\thumbnails\HD1920-856.jpg"; DestDir: "{userdocs}\{#Mydir}\images\thumbnails"
Source: "..\bin\debug\images\thumbnails\HD1366x720.jpg"; DestDir: "{userdocs}\{#Mydir}\images\thumbnails"
Source: "..\bin\debug\images\thumbnails\HD1920-2.jpg"; DestDir: "{userdocs}\{#Mydir}\images\thumbnails"

;song searched for

;db
Source: "..\bin\debug\db\db.mdb"; DestDir: "{userdocs}\{#Mydir}\db"
;Source: "..\bin\debug\help\installation.txt"; DestDir: "{app}\help"; Flags: isreadme


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
Name: "{group}\HeritageMediaSlidePlus"; Filename: "{app}\HeriageMediaSlidePlus.exe"
