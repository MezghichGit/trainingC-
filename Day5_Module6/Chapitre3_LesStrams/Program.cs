using System;
using System.IO;
namespace Chapitre3_LesStrams
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exemple 1
            /*
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(@"C:\Users\amine\Desktop\Lab\data.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }*/

            //Exemple 2

            // Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"C:\Users\amine\Desktop\Lab").GetDirectories();

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter(@"C:\Users\amine\Desktop\Lab\CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader(@"C:\Users\amine\Desktop\Lab\CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
        }
    }
}
