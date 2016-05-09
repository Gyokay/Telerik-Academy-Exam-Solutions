using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Absolute_Differences
{
    class Program
    {
        static void Main(string[] args)
        {
            byte T = byte.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string currentInput = Console.ReadLine();
                string[] splitArr = currentInput.Split(' ');
                int[] currentNumbers = new int[splitArr.Length];

                for (int j = 0; j < splitArr.Length; j++)
                {
                    currentNumbers[j] = int.Parse(splitArr[j]);
                }

                Console.WriteLine(IsIncreasingSeq(currentNumbers) ? "True" : "False");
            }
        }

        static bool IsIncreasingSeq(int[] currentNumbers)
        {
            bool isIncreasingSeq = true;

            int firstMax = Math.Max(currentNumbers[0], currentNumbers[1]);
            int firstMin = Math.Min(currentNumbers[0], currentNumbers[1]);

            int firstAbsoluteDiff = firstMax - firstMin;

            for (int i = 1; i <= currentNumbers.Length - 2; i++)
            {
                int max = Math.Max(currentNumbers[i], currentNumbers[i + 1]);
                int min = Math.Min(currentNumbers[i], currentNumbers[i + 1]);

                int absoluteDiff = max - min;

                int diffDiff = absoluteDiff - firstAbsoluteDiff;

                if (firstAbsoluteDiff <= absoluteDiff && (diffDiff == 0 || diffDiff == 1))
                {
                    firstAbsoluteDiff = absoluteDiff;
                    continue;
                }
                else
                {
                    return isIncreasingSeq = false;
                }
            }

            return isIncreasingSeq;
        }
    }
}
