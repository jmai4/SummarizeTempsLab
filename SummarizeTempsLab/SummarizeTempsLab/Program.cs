using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        { string fileName;
            // temperature data is in temps.txt
            Console.WriteLine("What is the name of your data file?");
           fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                Console.WriteLine("Enter threshold");
                string input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);

                int sumTemps = 0;
                int numAbove = 0;
                int numBelow = 0;

                using (StreamReader sr = File.OpenText(fileName))
                {

                    string line = sr.ReadLine();
                    int temp;
                    while (line != null)
                    {

                        temp = int.Parse(line);
                        sumTemps += temp;
                        if (temp >= threshold)
                        {
                            numAbove += 1;
                        }
                        else
                        {
                            numBelow += 1;
                        }

                        line = sr.ReadLine();
                    }
                }
                Console.WriteLine("Temperatures above =" + numAbove);

                Console.WriteLine("Temperatures below =" + numBelow);

                int average = sumTemps / (numAbove + numBelow);

                Console.WriteLine("Average temp =" + average);
            }
            else
            {
                Console.WriteLine("The file does not exist");
            }
        }

    }
}
