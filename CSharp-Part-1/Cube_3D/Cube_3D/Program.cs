using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_3D
{
    class Program
    {
        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());

            for (int row = 0; row < (N * 2) - 1; row++)
            {
                if (row == 0)
                {
                    for (int col = 0; col < N; col++)
                    {
                        Console.Write(':');
                    }
                }
                else if (row > 0 && row < N)
                {
                    for (int col = 0; col < N + row; col++)
                    {
                        if (col == 0)
                        {
                            Console.Write(':');
                        }
                        else if (col > 0 && col < N - 1)
                        {
                            if (row == N - 1)
                            {
                                Console.Write(':');
                            }
                            else
                            {
                                Console.Write(' ');
                            }
                        }
                        else if (col == N - 1)
                        {
                            Console.Write(':');
                        }
                        else if (col > N - 1 && col < N + row - 1)
                        {
                            Console.Write('|');
                        }
                        else if (col == N + row - 1)
                        {
                            Console.Write(':');
                        }
                    }
                }
                else if (row > N - 1 && row < N * 2 - 2)
                {
                    for (int i = 0; i <= row - N; i++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(':');

                    for (int i = 0; i < N - 2; i++)
                    {
                        Console.Write('-');
                    }

                    Console.Write(':');

                    for (int i = 0; i < N * 2 - 1 - row - 2 ; i++)
                    {
                        Console.Write('|');
                    }

                    Console.Write(':');
                }
                else
                {
                    for (int i = 0; i <= row - N; i++)
                    {
                        Console.Write(' ');
                    }

                    for (int i = 0; i < N; i++)
                    {
                        Console.Write(':');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
