using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadronacci_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long q1 = long.Parse(Console.ReadLine());
            long q2 = long.Parse(Console.ReadLine());
            long q3 = long.Parse(Console.ReadLine());
            long q4 = long.Parse(Console.ReadLine());

            int R = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            if (R == 4)
            {
                Console.Write("{0} {1} {2} {3}", q1, q2, q3, q4);
            }
            else
            {
                Console.Write("{0} {1} {2} {3} ", q1, q2, q3, q4);

            }

            long result = 0;

            for (int row = 0; row < R; row++)
            {
                int currentCol = 0;

                if (row == 0)
                {
                    currentCol = 4;
                }

                for (int col = currentCol; col < C; col++)
                {
                    result = q1 + q2 + q3 + q4;

                    q1 = q2;
                    q2 = q3;
                    q3 = q4;
                    q4 = result;

                    Console.Write(q4);

                    if (col != C - 1)
                    {
                        Console.Write(' ');
                    }
                }


                Console.WriteLine();
            }


        }
    }
}
