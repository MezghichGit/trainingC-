using System;
using System.IO;
using System.Text;

namespace Chapitre1_LesFichiers
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            /*
            string curFile = @"C:\Users\amine\Desktop\Lab\data.txt";
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");


            string path = @"C:\Users\amine\Desktop\Lab\data.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText, Encoding.UTF8); // creation
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8); // ajout

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            */

        // Correction exo 1:

        /*
        string curFile = @"C:\Users\amine\Desktop\Lab\Exo\eleves.txt";
        Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");


        string path = @"C:\Users\amine\Desktop\Lab\Exo\eleves.txt";
        // This text is added only once to the file.
        if (!File.Exists(path))
        {
            // Create a file to write to.
            string createText = "Des élèves" + Environment.NewLine;
            File.WriteAllText(path, createText, Encoding.UTF8); // creation
        }


        // This text is always added, making the file longer over time
        // if it is not deleted.
        for (int i = 0; i < 3; i++)
        {
            string appendText = Console.ReadLine() + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8); // ajout
        }

        // Open the file to read from.
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);
        */

        // Partie sur les Path
        /*
        string fileName1 = "myfile.ext";
        string fileName2 = @"mydir\myfile";
        string path = @"C:\mydir.ext\";
        bool result;

        result = Path.HasExtension(fileName1);
        Console.WriteLine("HasExtension('{0}') returns {1}", fileName1, result);

        result = Path.HasExtension(fileName2);
        Console.WriteLine("HasExtension('{0}') returns {1}",fileName2, result);

        result = Path.HasExtension(path);
        Console.WriteLine("HasExtension('{0}') returns {1}", path, result);
    }*/

        public static void Main(string[] args)
        {
            string path = @"C:\Users\amine\Desktop\Lab";
            // string path = @"C:\Users\amine\Desktop\Lab\data.txt";

            if (File.Exists(path))
            {
                // This path is a file
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                // This path is a directory
                ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("{ 0} is not a valid file or directory.", path);
            }

        }

        // Process all files in the directory passed in, recurse on any directories
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }
    }
}
