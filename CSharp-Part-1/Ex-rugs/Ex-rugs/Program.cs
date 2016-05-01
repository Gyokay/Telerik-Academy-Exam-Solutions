using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_rugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = 2 * n + 1;

            int d = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];

            if (d >= n)
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        arr[row, col] = 2;
                    }
                }
            }
            else if (d < n)
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (row == n / 2 - 1)
                        {

                        }
                    }
                }
            }

            // printing

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (arr[row, col] == 2)
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
