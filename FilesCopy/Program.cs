using System;
using System.IO;

namespace FilesCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            //by default omit System.IO in example System.IO.Directory.Exists,
            // can just type Directory.Exists since using System.IO

            string fileName = "";
            string sourcePath = @"c:\Project\DEVELOPMENT_VM\cSharpProjects\VisualStudio\FilesCopy\TestFolder\folder1";
            string targetPath = @"c:\Project\DEVELOPMENT_VM\cSharpProjects\VisualStudio\FilesCopy\TestFolder\folder2";

            string sourceFile = Path.Combine(sourcePath, fileName);
            string destinationFile = Path.Combine(targetPath, fileName);

            if (Directory.Exists(sourcePath))
            {
                if (Directory.Exists(targetPath))
                {

                    string[] files = Directory.GetFiles(sourcePath);

                    foreach (string s in files)
                    {
                        fileName = Path.GetFileName(s);
                        destinationFile = Path.Combine(targetPath, fileName);
                        File.Copy(s, destinationFile, true);
                    }
                    Console.WriteLine("Files have been copied");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit");
                }

                else
                {
                    Directory.CreateDirectory(targetPath);
                    Console.WriteLine("target directory was created");
                    string[] files = Directory.GetFiles(sourcePath);

                    foreach (string s in files)
                    {
                        fileName = Path.GetFileName(s);
                        destinationFile = Path.Combine(targetPath, fileName);
                        File.Copy(s, destinationFile, true);
                    }
                    Console.WriteLine("Files have been copied");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit");
                }
            }
            else
            {
                Console.WriteLine(" Source Path does not exist!");

            }

                Console.ReadKey();
                      
        }
    }
}
