using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_file
{
    internal class Program
    {
        static void Main(string[] args)
        {





            string filePath = "C:\\Users\\yahya\\Desktop\\NZSE IT Technical support materials\\firstfile.txt"; // Replace with the path to your file



            try
            {
                // Prompt the user for text to append to the file
                Console.WriteLine("Enter text to append to the file:");
                string textToAdd = Console.ReadLine();



                // Append the text to the file
                File.AppendAllText(filePath, textToAdd + Environment.NewLine);



                // Read and display the entire content of the file
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("File Content:");
                Console.WriteLine(fileContent);
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
/*
string filePath = "C:\\Users\\yahya\\Desktop\\NZSE IT Technical support materials\\firstfile.txt"; // Replace with the path to your file

try
{
    // Open the file for reading
    using (StreamReader reader = new StreamReader(filePath))
    {
        int lineCount = 0;

        // Read lines until we reach the end of the file or the first two lines
        while (lineCount < 2 && !reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (line != null)
            {
                Console.WriteLine(line);
                lineCount++;
            }
        }
    }
}
catch (IOException e)
{
    Console.WriteLine($"An error occurred: {e.Message}");
}
}
*/



