using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bat_Goyko_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int height = N;
            int width = height * 2;
            int crossbeam = 1;
            int steps = 2;

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width / 2 - row; col++)
                {
                    if (col == width / 2 - 1 - row)
                    {
                        Console.Write('/');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                if (row == crossbeam)
                {
                    string dash = new string('-', row * 2);
                    Console.Write(dash);

                    crossbeam += steps;
                    steps++;
                }
                else
                {
                    string dots = new string('.', row * 2);
                    Console.Write(dots);
                }

                for (int col = row; col < width / 2; col++)
                {
                    if (col == row)
                    {
                        Console.Write('\\');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
