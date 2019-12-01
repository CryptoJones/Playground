using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            puzzleOnePartTwo();
        }

        public static void puzzleOne()
        {
            var inputs = new List<int>();

            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"Puzzle1Inputs.txt");
            while ((line = file.ReadLine()) != null)
            {
                int result;
                Int32.TryParse(line, out result);
                inputs.Add(result);
                counter++;
            }

            file.Close();

            int sumOfInts = 0;
            foreach (int i in inputs)
            {
                int working = i / 3;
                working = working - 2;
                sumOfInts = sumOfInts + working;
            }

            Console.WriteLine("Done! The answer is " + sumOfInts.ToString());
            Console.ReadLine();
        }

        public static void puzzleOnePartTwo()
        {
            var inputs = new List<int>();

            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"Puzzle1Inputs.txt");
            while ((line = file.ReadLine()) != null)
            {
                int result;
                Int32.TryParse(line, out result);
                inputs.Add(result);
                counter++;
            }

            file.Close();

            double sumOfInts = 0;
            foreach (int i in inputs)
            {
                fuelcost(i);
            }

            Console.WriteLine("Done! The answer is " + sumOfInts.ToString());
            Console.ReadLine();

            void fuelcost(double initial)
            {
                double working = Math.Floor(initial / 3);
                working = working - 2;
                if (working > 0)
                {
                    sumOfInts = sumOfInts + working;
                }

                if (working > 0)
                {
                    fuelcost(working);
                }
            }
            Console.WriteLine("Done! The answer is " + sumOfInts.ToString());
            Console.ReadLine();
        }
    }
}
