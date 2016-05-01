using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];

            int slashStart = n / 2 - 1;
            int slashEnd = n / 2 - 1;

            bool isSlash = true;

            for (int row = 0; row < n / 2; row++)
            {
                for (int col = 0; col < n / 2; col++)
                {
                    if (slashStart <= col && col <= slashEnd)
                    {
                        if (isSlash)
                        {
                            arr[row, col] = 2;
                            arr[row, (n - 1) - col] = 3;
                            arr[(n - 1) - row, col] = 3;
                            arr[(n - 1) - row, (n - 1) - col] = 2;
                            isSlash = false;
                        }
                        else
                        {
                            arr[row, col] = 1;
                            arr[row, (n - 1) - col] = 1;
                            arr[(n - 1) - row, col] = 1;
                            arr[(n - 1) - row, (n - 1) - col] = 1;
                            isSlash = true;
                        }
                    }
                }
                isSlash = true;
                slashStart--;
            }

            //printign

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (arr[row, col] == 0)
                    {
                        Console.Write('.');
                    }
                    else if (arr[row, col] == 1)
                    {
                        Console.Write(' ');
                    }
                    else if (arr[row, col] == 2)
                    {
                        Console.Write('/');
                    }
                    else if (arr[row, col] == 3)
                    {
                        Console.Write('\\');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
