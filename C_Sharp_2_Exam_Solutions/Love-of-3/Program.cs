using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Love_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimensions[0], dimensions[1]];
            FillMatrix(matrix);

            int row = matrix.GetLength(0) - 1;
            int col = 0;

            long sum = 0;

            for (int i = 0; i < N; i++)
            {
                string[] currentDirections = Console.ReadLine().Split(' ').ToArray();

                string direction = currentDirections[0];
                int moves = int.Parse(currentDirections[1]);

                for (int j = 0; j < moves - 1; j++)
                {
                    if ((direction == "UR" || direction == "RU")
                        && col < matrix.GetLength(1) - 1
                        && row > 0)
                    {
                        row--;
                        col++;
                    }

                    //TO DO: Fill other cases

                    sum += matrix[row, col];
                    matrix[row, col] = 0;
                }



            }

            Console.WriteLine(sum);

        }
        static void FillMatrix(int[,] matrix)
        {
            int counter = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = ((matrix.GetLength(0) - 1) - row) * 3 + counter;
                }
                counter += 3;
            }
        }
    }
}
