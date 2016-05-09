using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Bit_Shift_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string[] split = input.Split(' ');

            int[] codes = new int[split.Length];

            for (int i = 0; i < split.Length; i++)
            {
                codes[i] = int.Parse(split[i]);
            }

            int coef = Math.Max(R, C);

            BigInteger[,] matrix = new BigInteger[R, C];
            FillMatrix(matrix);

            BigInteger sum = 0;

            int startRow = matrix.GetLength(0) - 1;
            int startCol = 0;

            for (int i = 0; i < N; i++)
            {
                int endRow = codes[i] / coef;
                int endCol = codes[i] % coef;
                sum += MoveToNext(startRow, startCol, endRow, endCol, matrix);

                startRow = endRow;
                startCol = endCol;
            }


            Console.WriteLine(sum);

        }

        static void FillMatrix(BigInteger[,] matrix)
        {

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int pow = col;

                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = (BigInteger)Math.Pow(2, pow++);
                }
            }
        }

        static BigInteger MoveToNext(int startRow, int startCol, int endRow, int endCol, BigInteger[,] matrix)
        {
            BigInteger sum = 0;

            sum += MoveToCol(startRow, startCol, endCol, matrix);
            sum += MoveToRow(startRow, endRow, endCol, matrix);

            return sum;
        }

        static BigInteger MoveToCol(int startRow, int startCol, int endCol, BigInteger[,] matrax)
        {
            BigInteger colSum = 0;

            if (startCol < endCol)
            {
                for (int i = startCol; i <= endCol; i++)
                {
                    colSum += matrax[startRow, i];
                    matrax[startRow, i] = 0;
                }

                return colSum;
            }
            else if (startCol > endCol)
            {
                for (int i = startCol; i >= endCol; i--)
                {
                    colSum += matrax[startRow, i];
                    matrax[startRow, i] = 0;
                }

                return colSum;
            }

            return colSum;
        }

        static BigInteger MoveToRow(int startRow, int endRow, int endCol, BigInteger[,] matrix)
        {
            BigInteger rowSum = 0;

            if (startRow > endRow)
            {
                for (int i = startRow; i >= endRow; i--)
                {
                    rowSum += matrix[i, endCol];
                    matrix[i, endCol] = 0;
                }
                return rowSum;
            }
            else if (startRow < endRow)
            {
                for (int i = startRow; i <= endRow; i++)
                {
                    rowSum += matrix[i, endCol];
                    matrix[i, endCol] = 0;
                }

                return rowSum;
            }

            return rowSum;
        }
    }
}
