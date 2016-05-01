using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int height = 2 * N;
            int width = 3 * N - 1;
            int drawingWidth = 3 * N + 1;
            int sizeTop = N - 1;

            int foo = 1;
            int tempSizeTop = sizeTop;

            if (N == 2)
            {
                Console.WriteLine("...*...\r\n.*@.@*.\r\n.*.@.*.\r\n...*...");
            }
            else
            {

                for (int row = 0; row < height; row++)
                {
                    if (row == 0 || row == height - 1)
                    {
                        var line = new StringBuilder();
                        var dots = new string('.', N + 1);
                        var stars = new string('*', sizeTop);
                        line.Append(dots);
                        line.Append(stars);
                        line.Append(dots);

                        Console.Write(line);
                    }

                    if (row >= 1 && row < N - 1)
                    {
                        for (int col = 0; col < drawingWidth; col++)
                        {
                            if (col == tempSizeTop || col == drawingWidth - tempSizeTop - 1)
                            {
                                Console.Write('*');
                            } 
                            else
                            {
                                Console.Write('.');
                            }
                        }

                        if (tempSizeTop > 1)
                        {
                            tempSizeTop -= 2;
                        }
                    }

                    if (row == N - 1)
                    {
                        for (int col = 0; col < drawingWidth; col++)
                        {
                            if (col == 0 || col == drawingWidth - 1)
                            {
                                Console.Write('.');
                            }
                            else if (col == 1 || col == drawingWidth - 2)
                            {
                                Console.Write('*');
                            }
                            else if (col % 2 == 0)
                            {
                                Console.Write('@');
                            }
                            else
                            {
                                Console.Write('.');
                            }
                        }
                    }
                    else if (row == N)
                    {
                        for (int col = 0; col < drawingWidth; col++)
                        {
                            if (col == 0 || col == drawingWidth - 1)
                            {
                                Console.Write('.');
                            }
                            else if (col == 1 || col == drawingWidth - 2)
                            {
                                Console.Write('*');
                            }
                            else if (col % 2 != 0)
                            {
                                Console.Write('@');
                            }
                            else
                            {
                                Console.Write('.');
                            }
                        }
                    }

                    if (row > N && row < height - 1) 
                    {
                        for (int col = 0; col < drawingWidth; col++)
                        {
                            if (col == foo || col == drawingWidth - foo - 1)
                            {
                                Console.Write('*');
                            }
                            else
                            {
                                Console.Write('.');
                            }
                        }

                        if (row > (N - 1) + (N - (N / 2)) - 1)
                        {
                            foo += 2;
                        }
                        
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
