using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Trolls
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int width = N * 2 + 1;
            int heght = (6 + ((N - 3) / 2) * 3);

            int middle = (heght - N) - 1;

            string dots = new string('.', (width - N) / 2);
            string stars = new string('*', N);
            Console.WriteLine(dots + stars + dots);

            int index = N / 2;
            int indexTwo = N / 2;

            for (int row = 1; row < middle; row++)
            {
                for (int col = 0; col < width / 2; col++)
                {
                    if (col == index)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                index--;
                Console.Write('*');

                for (int col = 0; col < width / 2; col++)
                {
                    if (col == indexTwo)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                indexTwo++;

                Console.WriteLine();
            }

            string middleStars = new string('*', width);
            Console.WriteLine(middleStars);

            for (int row = 0; row < N - 1; row++)
            {
                for (int col = 0; col < width / 2; col++)
                {
                    if (col == row + 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.Write('*');

                for (int col = 0; col < width / 2; col++)
                {
                    if (col == (width / 2) - (row + 2))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();
            }

            dots = new string('.', width / 2);
            Console.WriteLine(dots + '*' + dots);
        }
    }
}
