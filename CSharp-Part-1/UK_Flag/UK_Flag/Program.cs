using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UK_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int row = 0; row < N / 2; row++)
            {
                for (int col = 0; col < N / 2; col++)
                {
                    if (row == col)
                    {
                        Console.Write('\\');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.Write('|');

                for (int col = 0; col < N / 2; col++)
                {
                    if (col == N / 2 - 1 - row)
                    {
                        Console.Write('/');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
            StringBuilder middle = new StringBuilder();
            string dashes = new string('-', N / 2);
            middle.Append(dashes);
            middle.Append('*');
            middle.Append(dashes);
            Console.WriteLine(middle);

            for (int row = 0; row < N / 2; row++)
            {
                for (int col = 0; col < N / 2; col++)
                {
                    if (col == N / 2 - 1 - row)
                    {
                        Console.Write('/');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                Console.Write('|');

                for (int col = 0; col < N / 2; col++)
                {
                    if (row == col)
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
