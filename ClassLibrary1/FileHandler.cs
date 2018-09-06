using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class FileHandler
    {
        public static void BackupFile(string fileName)
        {
            //rename file with current timestamp

            string sourceFileName = Globals.fileDirectory + fileName;
            string backupFileName = Globals.backupDirectory + fileName;

            try
            {
                int index = backupFileName.IndexOf(".");
                var newFileName = backupFileName.Substring(0, index) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm_ssfff") + backupFileName.Substring(index);

                File.Move(sourceFileName, newFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(sourceFileName + "... the file could not be renamed/moved:");
                Console.WriteLine(ex.Message);
            }

            //// create an empty file ... this seems to cause contention

            //try
            //{
            //    var fred = File.Create(sourceFileName);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(sourceFileName + "... the file could not be created:");
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
