using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorySearch
{
    class Program
    {
        /// <summary>
        /// Function to List files and sufolders in a given directory
        /// </summary>
        /// <param name="sDir">The directory to search in</param>
        /// <param name="NumOfFiles">Number of files in the given directory</param>
        /// <param name="NumOfFolders">Number of sub folders in the given directory</param>
        /// <returns></returns>
        static List<String> DirSearch(string sDir,out int NumOfFiles,out int NumOfFolders)
        {
            List<String> files = new List<String>();
            int nfilesCount = 0;
            int nfoldersCount = 0;

            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    files.Add(f);
                    nfilesCount++;
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    files.AddRange(DirSearch(d,out NumOfFiles, out NumOfFolders));
                    nfoldersCount++;
                }
               
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
                NumOfFiles = nfilesCount;
                NumOfFolders = nfoldersCount;
            return files;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the directory to Search in : ");
            Console.WriteLine("********************************************");

            String sDirectory = Console.ReadLine();

            int filesnum = 0;
            int foldersnum = 0;

            List<string> lstFiles = DirSearch(sDirectory,out filesnum,out foldersnum);

            foreach (string file in lstFiles)
            {
               Console.WriteLine(file);
            }
            Console.WriteLine("********************************************");

            Console.WriteLine("Number of files = " + filesnum);
            Console.WriteLine("Number of folders= " + foldersnum);

            Console.ReadKey();

        }
    }
}
