using Microsoft.Synchronization.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft;

namespace folderSyncConsole
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            string sourceFolderPath = Directory.GetCurrentDirectory() + @"\MyDir\SourceFolder\";

            string destinationFolderPath = Directory.GetCurrentDirectory() + @"\MyDir\DestinationFolder\";

            int direction = 1;
=======
            string SourceFolderPath = @"C:\GIT_Repository\folderSyncConsole\folderSyncConsole\bin\Debug\MyDir\SourceFolder";
            string DestinationFolderPath = @"C:\GIT_Repository\folderSyncConsole\folderSyncConsole\bin\Debug\MyDir\DestinationFolder";
>>>>>>> 9e577616604180d575c8eadc741cf1e5f95c2618

            FileSyncScopeFilter mainFilter = new FileSyncScopeFilter();
            FileSyncOptions mainOptions = new FileSyncOptions();

            UnitTest test = new UnitTest();

            test.Prepare();
<<<<<<< HEAD
            DoSync doSync = new DoSync(sourceFolderPath, destinationFolderPath, mainFilter, mainOptions, direction);
            doSync.Sync();
            UnitTest.UpdateRight();
            //UnitTest.UpdateLeft();
=======
            DoSync doSync = new DoSync(SourceFolderPath, DestinationFolderPath, mainFilter, mainOptions);
            doSync.Sync();

>>>>>>> 9e577616604180d575c8eadc741cf1e5f95c2618
            Console.ReadLine();

        }


    }
}
