using System;
using System.IO;
using System.Text;

namespace Chapitre1_LesFichiers
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
