using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace folderSyncConsole
{
    public class UnitTest
    {
        private static List<string> fileNames = new List<string>();
        private static string sourceFolderPath = Directory.GetCurrentDirectory() + @"\MyDir\SourceFolder\";
        private static string destinationFolderPath = Directory.GetCurrentDirectory() + @"\MyDir\DestinationFolder\";

        private static string copySource = Directory.GetCurrentDirectory() + @"\1\SourceFolder\";
        private static string copyDest = Directory.GetCurrentDirectory() + @"\1\DestinationFolder\";

        private static string sourceFile = Directory.GetCurrentDirectory() + @"\textFiles\source.txt";
        private static string destFile = Directory.GetCurrentDirectory() + @"\textFiles\dest.txt";
        private static string updatedFile = Directory.GetCurrentDirectory() + @"\textFiles\updated.txt";
=======
namespace Microsoft
{
    public class UnitTest
    {
>>>>>>> 9e577616604180d575c8eadc741cf1e5f95c2618

        public void Prepare()
        {
            try
            {
<<<<<<< HEAD
                DeleteContent(sourceFolderPath);
                DeleteContent(destinationFolderPath);
                CopyContent(copySource, sourceFolderPath);
                CopyContent(copyDest, destinationFolderPath);
                //System.Diagnostics.Process proc = new System.Diagnostics.Process();
                //proc.StartInfo.FileName = Directory.GetCurrentDirectory() + @"\setDefaultConditions.bat";
                //proc.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                //proc.Start();
=======
                
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = @"C:\GIT_Repository\folderSyncConsole\folderSyncConsole\bin\Debug\setDefaultConditions.bat";
                proc.StartInfo.WorkingDirectory = @"C:\GIT_Repository\folderSyncConsole\folderSyncConsole\bin\Debug";
                proc.Start();
>>>>>>> 9e577616604180d575c8eadc741cf1e5f95c2618

                Console.WriteLine("Prepare done successfully");
            }
            catch
            {

                Console.WriteLine("Prepare failed");
            }
        }

<<<<<<< HEAD
        private void DeleteContent(string path)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        private void CopyContent(string copyPath, string targetPath)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(copyPath);
            FileInfo[] fi = di.GetFiles();
            foreach (FileInfo fiTemp in fi)
            {
                string sourceFile = System.IO.Path.Combine(copyPath, fiTemp.Name);
                string destFile = System.IO.Path.Combine(targetPath, fiTemp.Name);
                System.IO.File.Copy(sourceFile, destFile, true);
            }

        }

        private static bool Check(string filePath, string folderPath, List<string> list)
        {
            bool check = false;
            ReaderWritter.Readlines(filePath, fileNames);

            for (int i = 0; i < fileNames.Count; i++)
            {
                string fileName = System.IO.Path.Combine(folderPath, fileNames[i]);

                //TO DO: Need fix to filenames with spaces.

                if (File.Exists(fileName))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }

            }
            return check;

        }

        public static void UpdateLeft()
        {

            if (Check(updatedFile, sourceFolderPath, fileNames))
            {
                Console.WriteLine("SyncLeft done successfully");
            }
            else
            {
                Console.WriteLine("SyncLeft failed");
            }
        }

        public static void UpdateRight()
        {
            if (Check(updatedFile, destinationFolderPath, fileNames))
=======
        public void SyncLeft()
        {
            try
            {

                Console.WriteLine("SyncLeft done successfully");
            }
            catch
            {

                Console.WriteLine("SyncLeft done failed");
            }
        }

        public void SyncRight()
        {
            try
>>>>>>> 9e577616604180d575c8eadc741cf1e5f95c2618
            {

                Console.WriteLine("SyncRight done successfully");
            }
<<<<<<< HEAD
            else
            {

                Console.WriteLine("SyncRight failed");
            }
        }

        public void UpdateBoth()
        {

            if ((Check(updatedFile, sourceFolderPath, fileNames)) && Check(updatedFile, destinationFolderPath, fileNames))
            {
                Console.WriteLine("SyncBoth done successfully");
            }
            
            else
            {
                Console.WriteLine("SyncBoth failed");
=======
            catch
            {

                Console.WriteLine("SyncRight done failed");
            }
        }

        public void SyncBoth()
        {

            try
            {

                Console.WriteLine("SyncBoth done successfully");
            }
            catch
            {

                Console.WriteLine("SyncBoth done failed");
>>>>>>> 9e577616604180d575c8eadc741cf1e5f95c2618
            }
        }

        public void MirrorLeft()
        {
            try
            {

                Console.WriteLine("MirrorLeft done successfully");
            }
            catch
            {

<<<<<<< HEAD
                Console.WriteLine("MirrorLeft failed");
=======
                Console.WriteLine("MirrorLeft done failed");
>>>>>>> 9e577616604180d575c8eadc741cf1e5f95c2618
            }
        }

        public void MirrorRight()
        {

            try
            {

                Console.WriteLine("MirrorRight done successfully");
            }
            catch
            {

<<<<<<< HEAD
                Console.WriteLine("MirrorRight failed");
            }
        }



=======
                Console.WriteLine("SyncMirrorRightLeft done failed");
            }
        }

>>>>>>> 9e577616604180d575c8eadc741cf1e5f95c2618
    }
}
