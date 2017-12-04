using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01CS
{
    class Program
    {
        static void Main(string[] args)
        {
            PartOne();
            PartTwo();
        }

        static void PartTwo()
        {
            var input = File.ReadAllText("input.txt");
            var charArray = input.ToCharArray();
            int sum = 0;


            for (int i = 0; i < charArray.Length; i++)
            {
                int charValue = int.Parse(charArray[i].ToString());
                if (i >= charArray.Length/2)
                {
                    if (charArray[i] == charArray[i - (charArray.Length / 2)])
                    {
                        sum += charValue;
                    }
                }
                else
                {
                    if (charArray[i] == charArray[i + (charArray.Length/2)])
                    {
                        sum += charValue;
                    }
                }

            }

            Console.WriteLine($"Part 2 Answer: {sum}");

        }
        static void PartOne()
        {
            var input = File.ReadAllText("input.txt");
            int sum = 0;

            var charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                int charValue = int.Parse(charArray[i].ToString());
                if (i + 1 == charArray.Length)
                {
                    if (charArray[i] == charArray[0])
                    {
                        sum += charValue;
                    }
                }
                else
                {
                    if (charArray[i] == charArray[i + 1])
                    {
                        sum += charValue;
                    }
                }
                
            }

            Console.WriteLine($"Part 1 Answer: {sum}");
        }
    }
}
