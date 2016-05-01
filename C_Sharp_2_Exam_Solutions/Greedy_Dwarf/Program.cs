using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy_Dwarf
{
    class Program
    {
        static void Main(string[] args)
        {
            //1, 3, -6, 7, 4 ,1, 12
            //3
            //1, 2, -3
            //1, 3, -2
            //1, -1

            //Constraints
            //The numbers in the valley will be between 1 and 10 000 inclusive.
            //M will be between 1 and 500
            //Each pattern will contain at most 100 numbers
            //Each of the numbers in the valley or in the patterns will be between - 1000 and 1000

            string input = Console.ReadLine();
            short[] valley = ReadSplitParse(input);
            short m = short.Parse(Console.ReadLine());
            int maxScore = -20000;

            for (int i = 0; i < m; i++)
            {
                string pat = Console.ReadLine();
                short[] pattern = ReadSplitParse(pat);

                maxScore = Math.Max(maxScore, CheckPattern(pattern, valley));
            }

            Console.WriteLine(maxScore);

        }
        static public int CheckPattern(short[] pattern, short[] valley)
        {
            bool[] isVisited = new bool[valley.Length];
            int index = 0;
            int patternIndex = 0;
            int currenSconre = 0;
            while (true)
            {
                if (index > valley.Length - 1 || index < 0 || isVisited[index] == true)
                {
                    return currenSconre;
                }
                else
                {
                    currenSconre += valley[index];
                    isVisited[index] = true;
                    index += pattern[patternIndex];

                    if (patternIndex < pattern.Length - 1)
                    {
                        patternIndex++;
                    }
                    else
                    {
                        patternIndex = 0;
                    }
                }
            }
        }

        static public short[] ReadSplitParse(string input)
        {
            char[] delimiterChars = new char[] { ' ', ',' };
            string[] split = input.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            short[] output = new short[split.Length];

            for (int i = 0; i < split.Length; i++)
            {
                output[i] = short.Parse(split[i]);
            }

            return output;
        }
    }
}
