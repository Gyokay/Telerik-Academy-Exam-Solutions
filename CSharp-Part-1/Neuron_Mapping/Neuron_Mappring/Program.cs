using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron_Mappring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentNumber = Console.ReadLine();
                input.Add(currentNumber);
            }
                
            }

        Console.WriteLine();
        }

        static public char[,] FillMatrix(List<string> input)
        {
            char[,] output = new char[input.Count, 32];

            for (int row = 0; row < input.Count; row++)
            {
                string currentRow = Convert.ToString(uint.Parse(input[row]), 2).PadLeft(32, '0');

                for (int col = 0; col < 32; col++)
                {
                    output[row, col] = currentRow[col];
                }
            }

            return output;
        }

        //test method: to check if the algorithms work properly
        static public void PrintMatrix(char[,] charArr)
        {
            for (int row = 0; row < charArr.GetLength(0); row++)
            {
                for (int col = 0; col < charArr.GetLength(1); col++)
                {
                    Console.Write(charArr[row, col]);
                }
                Console.WriteLine();
            }
        }

        static public List<uint> ConvertToInt(char[,] charArr)
        {
            List<uint> output = new List<uint>();

            for (int row = 0; row < charArr.GetLength(0); row++)
            {
                StringBuilder currentRow = new StringBuilder();

                for (int col = 0; col < charArr.GetLength(1); col++)
                {
                    currentRow.Append(charArr[row, col]);
                }

                output.Add(Convert.ToUInt32(currentRow.ToString(), 2));
            }

            return output;
        }

        static public void FlipMatrix(char[,] inputArr)
        {
            for (int row = 0; row < inputArr.GetLength(0); row++)
            {
                for (int col = 0; col < inputArr.GetLength(1); col++)
                {
                    if (inputArr[row, col] == '0')
                    {
                        inputArr[row, col] = '1';
                    }
                    else
                    {
                        inputArr[row, col] = '2';
                    }
                }
            }
        }

        static public void NormalizeMatrix(char[,] inputArr)
        {

            //straight loop: 0 -> length - 1
            for (int row = 0; row < inputArr.GetLength(0); row++)
            {
                for (int col = 0; col < inputArr.GetLength(1); col++)
                {
                    if (inputArr[row, col] == '1')
                    {
                        inputArr[row, col] = '0';
                    }
                    else if (inputArr[row, col] == '2')
                    {
                        break;
                    }
                }

            }

            //reversed loop: length - 1 -> 0
            for (int row = inputArr.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = inputArr.GetLength(1) - 1; col >= 0; col--)
                {
                    if (inputArr[row, col] == '1')
                    {
                        inputArr[row, col] = '0';
                    }
                    else if (inputArr[row, col] == '2')
                    {
                        break;
                    }
                }
            }

            //clear the edges
            for (int row = 0; row < inputArr.GetLength(0); row++)
            {
                for (int col = 0; col < inputArr.GetLength(1); col++)
                {
                    if (inputArr[row, col] == '2')
                    {
                        inputArr[row, col] = '0';
                    }
                }

            }
        }
    }

