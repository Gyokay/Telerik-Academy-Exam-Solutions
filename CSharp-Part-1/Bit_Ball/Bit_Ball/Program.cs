using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];

            int upTeamScore = 0;
            int bottomTeamScore = 0;

            for (int i = 0; i < 8; i++) //up Team
            {
                int currentNumber = int.Parse(Console.ReadLine());

                for (int j = 0; j < 8; j++)
                {
                    int mask = 1 << j;

                    bool isABit = (currentNumber & mask) != 0;

                    if (isABit)
                    {
                        matrix[i, 7 - j] = 1;
                    }
                }
            }

            for (int i = 0; i < 8; i++) //bottom Team
            {
                int currentNumber = int.Parse(Console.ReadLine());

                for (int j = 0; j < 8; j++)
                {
                    int mask = 1 << j;

                    bool isABit = (currentNumber & mask) != 0;

                    if (isABit)
                    {
                        if (matrix[i, 7 - j] == 1)
                        {
                            matrix[i, 7 - j] = 0;
                        }
                        else
                        {
                            matrix[i, 7 - j] = 2;
                        }
                    }
                }
            }

            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        break;
                    }
                    else if (matrix[row, col] == 2)
                    {
                        bottomTeamScore++;
                        break;
                    }
                }
            }

            for (int col = 7; col >= 0; col--)
            {
                for (int row = 7; row >= 0; row--)
                {
                    if (matrix[row, col] == 2)
                    {
                        break;
                    }
                    else if (matrix[row, col] == 1)
                    {
                        upTeamScore++;
                        break;
                    }
                }
            }

            Console.WriteLine("{0}:{1}", upTeamScore, bottomTeamScore);

            // for checking if the matrix algorithm works
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
