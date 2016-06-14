using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            int width = s * 3;
            int height = ((s / 2) * 2) + (s / 3);
            int middleSection = s / 3; //(s / 2) - 1;

            int wingCounter = s;
            int wingSpaces = 0;
            int tailCount = s - 2;
            for (int row = 0; row < height; row++)
            {

                //top part
                if (row >= 0 && row <= (s / 2) - 1)
                {
                    Console.Write(new string(' ', wingSpaces));
                    Console.Write(new string(symbol, wingCounter));

                    if (row == (s / 2) - 1)
                    {
                        Console.Write(new string(' ', (s / 2) - 1));
                        Console.Write(symbol);
                        Console.Write(' ');
                        Console.Write(symbol);
                        Console.Write(new string(' ', (s / 2) - 1));
                    }
                    else
                    {
                        Console.Write(new string(' ', s));
                    }

                    Console.Write(new string(symbol, wingCounter));
                    Console.Write(new string(' ', wingSpaces));

                    wingSpaces++;
                    wingCounter--;
                }


                //middle part
                if (row >= s / 2 && row <= (s / 2) + (middleSection - 1))
                {
                    Console.Write(new string(' ', wingSpaces));
                    Console.Write(new string(symbol, width - (wingSpaces * 2)));
                    Console.Write(new string(' ', wingSpaces));
                }


                if (row > (s / 2) + (middleSection - 1))
                {
                    Console.Write(new string(' ', (width - tailCount) / 2));
                    Console.Write(new string(symbol, tailCount));
                    Console.Write(new string(' ', (width - tailCount) / 2));

                    tailCount -= 2;
                }

                Console.WriteLine();
            }
        }
    }
}
