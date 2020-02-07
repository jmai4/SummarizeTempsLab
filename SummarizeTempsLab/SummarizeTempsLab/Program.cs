using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // temperature data is in temps.txt
            Console.WriteLine("What is the name of your data file?");
            string tempfile = Console.ReadLine();

            if (File.Exists(tempfile))
            {

            }
            else
            {
                Console.WriteLine("The file does not exist");
            }
        }
    }
}
