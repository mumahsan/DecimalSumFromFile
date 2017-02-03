using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDecimalFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read ALL Lines.
            string[] allLines = File.ReadAllLines("C:/Data/test.txt");
            //string[] allLines = { "1.2	2.3", "2.3	4.5" };
            foreach (string line in allLines)
            {
                Console.WriteLine(line);
            }
            foreach (string line in allLines)
            {
                string lineWOSpace = line.TrimEnd().TrimStart();
                string[] lineStrings = lineWOSpace.Split(new char[0]);
                //Console.WriteLine(lineWOSpace);

                decimal sum = 0;
                foreach (var num in lineStrings)
                {
                    decimal result = 0;
                    if (decimal.TryParse(num, out result))
                        sum += result;
                }
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
