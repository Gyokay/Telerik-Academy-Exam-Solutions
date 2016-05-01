using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                int number = int.Parse(Console.ReadLine());

                for (int j = 0; j < 8; j++)
                {
                    int mask = 1 << j;

                    bool isABit = (number & mask) != 0;

                    if (isABit)
                    {
                        matrix[i, 7 - j] = 1;
                    }
                }
            }

            int[] colSumsArr = new int[8];

            for (int col = 0; col < 8; col++)
            {
                int counter = 0;

                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        counter++;
                    }
                }

                colSumsArr[col] = counter;
            }

            for (int i = 0; i < 8; i++) //colons
            {
                int sumRight = 0;
                for (int j = i + 1; j < 8; j++)
                {
                    sumRight += colSumsArr[j];
                }

                int sumLeft = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += colSumsArr[j];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(7 - i);
                    Console.WriteLine(sumRight);
                    break;
                }

                if (i == 7)
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
