using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Files;


namespace folderSyncConsole
{
    public class DoSync// : FileSyncProvider
    {
<<<<<<< HEAD
        private string sourceFolderPath;
        private string destinationFolderPath;
        private int direction;
        private FileSyncScopeFilter filter;
        private FileSyncOptions options;
        private FileSyncProvider sourceFolder = null;
        private FileSyncProvider destinationFolder = null;

        public DoSync(string sourceFolder, string destinationFolder, FileSyncScopeFilter outFilter, FileSyncOptions outOptions, int outDirection)
        {
            sourceFolderPath = sourceFolder;
            destinationFolderPath = destinationFolder;
            filter = outFilter;
            options = outOptions;
            direction = outDirection;
=======
        private string SourceFolderPath;
        private string DestinationFolderPath;
        private FileSyncScopeFilter filter;
        private FileSyncOptions options;
        private FileSyncProvider SourceFolder = null;
        private FileSyncProvider DestinationFolder = null;

        public DoSync(string SourceFolder, string DestinationFolder, FileSyncScopeFilter outFilter, FileSyncOptions outOptions)
        {
            SourceFolderPath = SourceFolder;
            DestinationFolderPath = DestinationFolder;
            filter = outFilter;
            options = outOptions;
>>>>>>> 9e577616604180d575c8eadc741cf1e5f95c2618
        }

        public void Sync()
        {
<<<<<<< HEAD
            sourceFolder = new FileSyncProvider(sourceFolderPath, filter, options);
            destinationFolder = new FileSyncProvider(destinationFolderPath, filter, options);
            SyncOrchestrator sync = new SyncOrchestrator();
            sync.LocalProvider = sourceFolder;
            sync.RemoteProvider = destinationFolder;
            
            switch (direction)
            {
                case 1:
                    sync.Direction = SyncDirectionOrder.Upload;
                    break;
                case 2:
                    sync.Direction = SyncDirectionOrder.Download;
                    break;
                case 3:
                    sync.Direction = SyncDirectionOrder.DownloadAndUpload;
                    break;
            }
=======
            SourceFolder = new FileSyncProvider(SourceFolderPath, filter, options);
            DestinationFolder = new FileSyncProvider(DestinationFolderPath, filter, options);
            SyncOrchestrator sync = new SyncOrchestrator();
            sync.LocalProvider = SourceFolder;
            sync.RemoteProvider = DestinationFolder;
            sync.Direction = SyncDirectionOrder.Upload;

>>>>>>> 9e577616604180d575c8eadc741cf1e5f95c2618
            string msg;
            try
            {
                // Synchronize data between the two providers.
                SyncOperationStatistics stats = sync.Synchronize();

                // Display statistics for the synchronization operation.
                msg = "Synchronization succeeded!\n\n" +
                    stats.DownloadChangesApplied + " download changes applied\n" +
                    stats.DownloadChangesFailed + " download changes failed\n" +
                    stats.UploadChangesApplied + " upload changes applied\n" +
                    stats.UploadChangesFailed + " upload changes failed";
            }
            catch (Exception ex)
            {
                msg = "Synchronization failed! Here's why: \n\n" + ex.Message;
            }
            Console.WriteLine(msg, "Synchronization Results");
        }


    }




}

