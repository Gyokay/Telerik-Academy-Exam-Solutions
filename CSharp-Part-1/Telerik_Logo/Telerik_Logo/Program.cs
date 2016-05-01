using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = x;
            int z = (x / 2) + 1;

            int width = (x * 2) + (z * 2) - 3;
            int hegth = (x * 3) - 2;

            int counter = 0;
            int counterTwo = 1;

            int[,] arr = new int[hegth, width];

            for (int row = 0; row < hegth; row++)
            {
                for (int col = 0; col < z + (x * 2) - 2; col++)
                {
                    if (col == z - 1 + counter)
                    {
                        arr[row, col] = 1;
                        arr[row, width - col - 1] = 1;
                    }

                    if (row > 0 && row < z && col == z - row - 1)
                    {
                        arr[row, col] = 1;
                        arr[row, width - col - 1] = 1;
                    }
                }
                counter++;
            }

            for (int row = x * 2 - 1; row < width; row++)
            {
                for (int col = 0; col <= width / 2; col++)
                {
                    if (col == z - 1 + counterTwo)
                    {
                        arr[row, col] = 1;
                        arr[row, width - col - 1] = 1;
                    }
                }
                counterTwo++;
            }

            //printing
            for (int row = 0; row < hegth; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (arr[row, col] == 0)
                    {
                        Console.Write('.');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }



        }
    }
}
