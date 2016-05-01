using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest_Road
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());

            int height = width * 2 - 1;

            int[,] arr = new int[height, width];

            for (int row = 0; row < height / 2 + 1; row++)
            {
                arr[row, row] = 1;
                arr[height - 1 - row, row] = 1;
            }

            //printing
            for (int row = 0; row < height; row++)
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
