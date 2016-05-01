using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = height * 2 - 3;

            for (int row = 0; row < height - 1; row++)
            {
                for (int col = 0; col < width / 2; col++)
                {
                    if (col >= width / 2 - row)
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
                    if (col < row)
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
            string dots = new string('.', height - 2);

            Console.WriteLine(dots + '*' + dots);
        }
    }
}
