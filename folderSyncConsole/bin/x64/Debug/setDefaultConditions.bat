@RD /S /Q "D:\VS_projects\folderSyncConsole\folderSyncConsole\bin\Debug\MyDir\DestinationFolder"
@RD /S /Q "D:\VS_projects\folderSyncConsole\folderSyncConsole\bin\Debug\MyDir\SourceFolder"

XCOPY "D:\VS_projects\folderSyncConsole\folderSyncConsole\bin\Debug\1\DestinationFolder" "D:\VS_projects\folderSyncConsole\folderSyncConsole\bin\Debug\MyDir\DestinationFolder" /D /E /C /R /I /K /Y 

XCOPY "D:\VS_projects\folderSyncConsole\folderSyncConsole\bin\Debug\1\SourceFolder" "D:\VS_projects\folderSyncConsole\folderSyncConsole\bin\Debug\MyDir\SourceFolder" /D /E /C /R /I /K /Y 