using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhead
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[16, 16];

            for (int i = 0; i < 16; i++)
            {
                string currentRow = Console.ReadLine();

                for (int j = 0; j < 16; j++)
                {
                    arr[i, j] = currentRow[j] - '0';
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                byte row = 0;
                byte col = 0;

                string color = "";

                if (command != "cut")
                {
                    row = byte.Parse(Console.ReadLine());
                    col = byte.Parse(Console.ReadLine());
                }
                else
                {
                    color = Console.ReadLine();
                }

                if (command == "hover")
                {
                    if (arr[row, col] == 1)
                    {
                        Console.WriteLine('*');
                    }
                    else
                    {
                        Console.WriteLine('-');
                    }
                }
                else if (command == "operate")
                {
                    if (arr[row, col] == 0 && row > 0 && row < 15 && col > 0 && col < 15)
                    {
                        if (arr[row - 1, col - 1] == 1 &&
                            arr[row - 1, col] == 1 &&
                            arr[row - 1, col + 1] == 1 &&
                            arr[row, col - 1] == 1 &&
                            arr[row, col + 1] == 1 &&
                            arr[row + 1, col - 1] == 1 &&
                            arr[row + 1, col] == 1 &&
                            arr[row + 1, col + 1] == 1)
                        {
                            arr[row - 1, col - 1] = 0;
                            arr[row - 1, col] = 0;
                            arr[row - 1, col + 1] = 0;
                            arr[row, col - 1] = 0;
                            arr[row, col + 1] = 0;
                            arr[row + 1, col - 1] = 0;
                            arr[row + 1, col] = 0;
                            arr[row + 1, col + 1] = 0;
                        }
                    }
                    else if (arr[row, col] == 1)
                    {
                        int totalCount = CountRed(arr) + CountBlue(arr);

                        Console.WriteLine("missed");
                        Console.WriteLine(totalCount);
                        Console.WriteLine("BOOM");

                        break;
                    }

                }
                else if (command == "cut")
                {
                    if (color == "red")
                    {
                        if (CountRed(arr) > 0)
                        {
                            Console.WriteLine(CountRed(arr));
                            Console.WriteLine("BOOM");

                            break;
                        }
                        else
                        {
                            Console.WriteLine(CountBlue(arr));
                            Console.WriteLine("disarmed");

                            break;
                        }
                    }
                    else if (color == "blue")
                    {
                        if (CountBlue(arr) > 0)
                        {
                            Console.WriteLine(CountBlue(arr));
                            Console.WriteLine("BOOM");

                            break;
                        }
                        else
                        {
                            Console.WriteLine(CountRed(arr));
                            Console.WriteLine("disarmed");

                            break;
                        }
                    }
                }
            }
        }

        private static void Print(int[,] arr)
        {
            for (int row = 0; row < 16; row++)
            {
                for (int col = 0; col < 16; col++)
                {
                    Console.Write(arr[row, col]);
                }
                Console.WriteLine();
            }

        }

        public static int CountRed(int[,] arr)
        {
            int count = 0;

            for (int row = 1; row < 15; row++)
            {
                for (int col = 1; col < 7; col++)
                {
                    if (arr[row, col] == 0)
                    {
                        if (arr[row - 1, col - 1] == 1 &&
                            arr[row - 1, col] == 1 &&
                            arr[row - 1, col + 1] == 1 &&
                            arr[row, col - 1] == 1 &&
                            arr[row, col + 1] == 1 &&
                            arr[row + 1, col - 1] == 1 &&
                            arr[row + 1, col] == 1 &&
                            arr[row + 1, col + 1] == 1)
                        {
                            arr[row - 1, col - 1] = 0;
                            arr[row - 1, col] = 0;
                            arr[row - 1, col + 1] = 0;
                            arr[row, col - 1] = 0;
                            arr[row, col + 1] = 0;
                            arr[row + 1, col - 1] = 0;
                            arr[row + 1, col] = 0;
                            arr[row + 1, col + 1] = 0;

                            count++;
                        }
                    }
                }
            }

            return count;
        }

        public static int CountBlue(int[,] arr)
        {
            int count = 0;

            for (int row = 1; row < 15; row++)
            {
                for (int col = 9; col < 15; col++)
                {
                    if (arr[row, col] == 0)
                    {
                        if (arr[row - 1, col - 1] == 1 &&
                            arr[row - 1, col] == 1 &&
                            arr[row - 1, col + 1] == 1 &&
                            arr[row, col - 1] == 1 &&
                            arr[row, col + 1] == 1 &&
                            arr[row + 1, col - 1] == 1 &&
                            arr[row + 1, col] == 1 &&
                            arr[row + 1, col + 1] == 1)
                        {
                            arr[row - 1, col - 1] = 0;
                            arr[row - 1, col] = 0;
                            arr[row - 1, col + 1] = 0;
                            arr[row, col - 1] = 0;
                            arr[row, col + 1] = 0;
                            arr[row + 1, col - 1] = 0;
                            arr[row + 1, col] = 0;
                            arr[row + 1, col + 1] = 0;

                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
