using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Na_Baba_mi_Smetalnika
{
    class Program
    {
        static void Main(string[] args)
        {
            byte width = byte.Parse(Console.ReadLine());

            var arr = new int[8, width];

            for (int i = 0; i < 8; i++)
            {
                long number = long.Parse(Console.ReadLine());

                string row = Convert.ToString(number, 2).PadLeft(width, '0');

                for (int j = 0; j < row.Length; j++)
                {
                    arr[i, j] = row[j] - '0';
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "reset")
                {
                    for (int row = 0; row < 8; row++)
                    {
                        var newArr = new int[width];
                        for (int col = 0; col < width; col++)
                        {
                            newArr[col] = arr[row, col];
                        }

                        Array.Sort(newArr);
                        Array.Reverse(newArr);

                        for (int col = 0; col < width; col++)
                        {
                            arr[row, col] = newArr[col];
                        }
                    }
                }
                else if (command == "right")
                {
                    byte row = byte.Parse(Console.ReadLine());
                    byte index = byte.Parse(Console.ReadLine());

                    var newArr = new int[width];
                    for (int col = 0; col < width; col++)
                    {
                        newArr[col] = arr[row, col];
                    }

                    Array.Sort(newArr, index, width - index);

                    for (int col = 0; col < width; col++)
                    {
                        arr[row, col] = newArr[col];
                    }
                }
                else if (command == "left")
                {
                    byte row = byte.Parse(Console.ReadLine());
                    byte index = byte.Parse(Console.ReadLine());

                    var newArr = new int[width];
                    for (int col = 0; col < width; col++)
                    {
                        newArr[col] = arr[row, col];
                    }

                    var sortArr = new int[index + 1];

                    for (int i = 0; i < sortArr.Length; i++)
                    {
                        sortArr[i] = arr[row, i];
                    }

                    Array.Sort(sortArr);
                    Array.Reverse(sortArr);

                    for (int col = 0; col < index; col++)
                    {
                        arr[row, col] = sortArr[col];
                    }
                }
                else if (command == "stop")
                {
                    BigInteger result = 0;
                    int emptyCollums = 0;

                    for (int col = 0; col < width; col++)
                    {
                        int empty = 0;

                        for (int row = 0; row < 8; row++)
                        {
                            if (arr[row, col] == 0)
                            {
                                empty++;
                            }
                        }

                        if (empty == 8)
                        {
                            emptyCollums++;
                        }
                    }

                    for (int row = 0; row < 8; row++)
                    {
                        var currentString = new StringBuilder();
                        for (int col = 0; col < width; col++)
                        {
                            currentString.Append(arr[row, col]);
                        }

                        long currentInt = Convert.ToInt32(currentString.ToString(), 2);
                        result += currentInt;
                    }

                    result *= emptyCollums;

                    Console.WriteLine(result);
                    break;
                }
            }

            //Print(arr);
        }

        private static void Print(int[,] arr)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Console.Write(arr[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
