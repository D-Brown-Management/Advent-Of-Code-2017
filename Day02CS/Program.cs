using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02CS
{
    class Program
    {
        static void Main(string[] args)
        {
            PartOne();
            PartTwo();
        }

        private static void PartTwo()
        {
            int checksum = 0;
            var lines = File.ReadAllLines("input.txt");

            foreach (var line in lines)
            {
                checksum += RowChecksumTwo(line);
            }

            Console.WriteLine($"Part 2: {checksum}");
        }

        private static int RowChecksumTwo(string row)
        {
            string[] numbers = row.Split('\t');
            int[] numbersInts = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersInts[i] = int.Parse(numbers[i]);
            }

            for (int j = 0; j < numbersInts.Length; j++)
            {             

                for (int k = 0; k < numbersInts.Length; k++)
                {
                    if (j == k)
                    {
                        continue;
                    }

                    if (numbersInts[j] % numbersInts[k] == 0)
                    {
                        return numbersInts[j] / numbersInts[k];
                    }
                }
            }

            return 0;
        }

        static void PartOne()
        {
            int checksum = 0;
            var lines = File.ReadAllLines("input.txt");

            foreach (var line in lines)
            {
                checksum += RowChecksum(line);
            }

            Console.WriteLine($"Part 1: {checksum}");
        }

        static int RowChecksum(string row)
        {
            int min = 99999999;
            int max = 0;
            string[] numbers = row.Split('\t');
            int[] numbersInts = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersInts[i] = int.Parse(numbers[i]);
            }

            for (int j = 0; j < numbersInts.Length; j++)
            {
                if (numbersInts[j] > max)
                {
                    max = numbersInts[j];
                }

                if (numbersInts[j] < min)
                {
                    min = numbersInts[j];
                }
            }

            


            return max-min;
        }
    }
}
