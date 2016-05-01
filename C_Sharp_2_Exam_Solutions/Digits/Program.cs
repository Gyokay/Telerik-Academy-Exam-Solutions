using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //nullable array isn't needed
            int?[,] matrix = new int?[n, n];

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                var nums = currentRow.Split(' ');

                for (int col = 0; col < nums.Length; col++)
                {
                    matrix[row, col] = nums[col][0] - '0';
                }
            }

            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int? currentDigit = matrix[row, col];

                    if (currentDigit == 1 && col > 1 && row <= n - 5)
                    {
                        if (FindOnes(matrix, row, col))
                        {
                            sum++;
                        }
                    }
                    else if (currentDigit == 2 && row <= n - 5 && col > 0 && col < n - 1)
                    {
                        if (FindTwos(matrix, row, col))
                        {
                            sum += 2;
                        }
                    }
                    else if (currentDigit == 3 && row <= n - 5 && col <= n - 3)
                    {
                        if (FindThrees(matrix, row, col))
                        {
                            sum += 3;
                        }
                    }
                    else if (currentDigit == 4 && row <= n - 5 && col <= n - 3)
                    {
                        if (FindFours(matrix, row, col))
                        {
                            sum += 4;
                        }
                    }
                    else if (currentDigit == 5 && row <= n - 5 && col <= n - 3)
                    {
                        if (FindFives(matrix, row, col))
                        {
                            sum += 5;
                        }
                    }
                    else if (currentDigit == 6 && row <= n - 5 && col <= n - 3)
                    {
                        if (FindSixes(matrix, row, col))
                        {
                            sum += 6;
                        }
                    }
                    else if (currentDigit == 7 && row <= n - 5 && col <= n - 3)
                    {
                        if (FindSevens(matrix, row, col))
                        {
                            sum += 7;
                        }
                    }
                    else if (currentDigit == 8 && row <= n - 5 && col <= n - 3)
                    {
                        if (FindEights(matrix, row, col))
                        {
                            sum += 8;
                        }
                    }
                    else if (currentDigit == 9 && row <= n - 5 && col <= n - 3)
                    {
                        if (FindNines(matrix, row, col))
                        {
                            sum += 9;
                        }
                    }
                    
                }
            }

            Console.WriteLine(sum);
        }

        static public bool FindOnes(int?[,] matrix, int row, int col)
        {
            bool isOne = matrix[row + 1, col - 1] == 1 &&
                         matrix[row + 1, col] == 1 &&
                         matrix[row + 2, col - 2] == 1 &&
                         matrix[row + 2, col] == 1 &&
                         matrix[row + 3, col] == 1 &&
                         matrix[row + 4, col] == 1;

            return isOne;
        }

        static public bool FindTwos(int?[,] matrix, int row, int col)
        {
            bool isTwo = matrix[row + 1, col - 1] == 2 &&
                         matrix[row + 1, col + 1] == 2 &&
                         matrix[row + 2, col + 1] == 2 &&
                         matrix[row + 3, col] == 2 &&
                         matrix[row + 4, col - 1] == 2 &&
                         matrix[row + 4, col] == 2 &&
                         matrix[row + 4, col + 1] == 2;

            return isTwo;
        }

        static public bool FindThrees(int?[,] matrix, int row, int col)
        {
            bool isThree = matrix[row, col + 1] == 3 &&
                           matrix[row, col + 2] == 3 &&
                           matrix[row + 1, col + 2] == 3 &&
                           matrix[row + 2, col + 1] == 3 &&
                           matrix[row + 2, col + 2] == 3 &&
                           matrix[row + 3, col + 2] == 3 &&
                           matrix[row + 4, col] == 3 &&
                           matrix[row + 4, col + 1] == 3 &&
                           matrix[row + 4, col + 2] == 3;

            return isThree;
        }

        static public bool FindFours(int?[,] matrix, int row, int col)
        {
            bool isFour = matrix[row, col] == 4 &&
                          matrix[row, col + 2] == 4 &&
                          matrix[row + 1, col] == 4 &&
                          matrix[row + 1, col + 2] == 4 &&
                          matrix[row + 2, col] == 4 &&
                          matrix[row + 2, col + 1] == 4 &&
                          matrix[row + 2, col + 2] == 4 &&
                          matrix[row + 3, col + 2] == 4 &&
                          matrix[row + 4, col + 2] == 4;

            return isFour;
        }

        static public bool FindFives(int?[,] matrix, int row, int col)
        {
            bool isFive = matrix[row, col] == 5 &&
                          matrix[row, col + 1] == 5 &&
                          matrix[row, col + 2] == 5 &&
                          matrix[row + 1, col] == 5 &&
                          matrix[row + 2, col] == 5 &&
                          matrix[row + 2, col + 1] == 5 &&
                          matrix[row + 2, col + 2] == 5 &&
                          matrix[row + 3, col + 2] == 5 &&
                          matrix[row + 4, col] == 5 &&
                          matrix[row + 4, col + 1] == 5 &&
                          matrix[row + 4, col + 2] == 5;

            return isFive;
        }

        static public bool FindSixes(int?[,] matrix, int row, int col)
        {
            bool isSix = matrix[row, col] == 6 &&
                         matrix[row, col + 1] == 6 &&
                         matrix[row, col + 2] == 6 &&
                         matrix[row + 1, col] == 6 &&
                         matrix[row + 2, col] == 6 &&
                         matrix[row + 2, col + 1] == 6 &&
                         matrix[row + 2, col + 2] == 6 &&
                         matrix[row + 3, col] == 6 &&
                         matrix[row + 3, col + 2] == 6 &&
                         matrix[row + 4, col] == 6 &&
                         matrix[row + 4, col + 1] == 6 &&
                         matrix[row + 4, col + 2] == 6;

            return isSix;
        }

        static public bool FindSevens(int?[,] matrix, int row, int col)
        {
            bool isSeven = matrix[row, col] == 7 &&
                           matrix[row, col + 1] == 7 &&
                           matrix[row, col + 2] == 7 &&
                           matrix[row + 1, col + 2] == 7 &&
                           matrix[row + 2, col + 1] == 7 &&
                           matrix[row + 3, col + 1] == 7 &&
                           matrix[row + 4, col + 1] == 7;

            return isSeven;
        }

        static public bool FindEights(int?[,] matrix, int row, int col)
        {
            bool isEight = matrix[row, col] == 8 &&
                           matrix[row, col + 1] == 8 &&
                           matrix[row, col + 2] == 8 &&
                           matrix[row + 1, col] == 8 &&
                           matrix[row + 1, col + 2] == 8 &&
                           matrix[row + 2, col + 1] == 8 &&
                           matrix[row + 3, col] == 8 &&
                           matrix[row + 3, col + 2] == 8 &&
                           matrix[row + 4, col] == 8 &&
                           matrix[row + 4, col + 1] == 8 &&
                           matrix[row + 4, col + 2] == 8;

            return isEight;
        }

        static public bool FindNines(int?[,] matrix, int row, int col)
        {
            bool isNine = matrix[row, col] == 9 &&
                          matrix[row, col + 1] == 9 &&
                          matrix[row, col + 2] == 9 &&
                          matrix[row + 1, col] == 9 &&
                          matrix[row + 1, col + 2] == 9 &&
                          matrix[row + 2, col + 1] == 9 &&
                          matrix[row + 2, col + 2] == 9 &&
                          matrix[row + 3, col + 2] == 9 &&
                          matrix[row + 4, col] == 9 &&
                          matrix[row + 4, col + 1] == 9 &&
                          matrix[row + 4, col + 2] == 9;

            return isNine;
        }
    }
}
