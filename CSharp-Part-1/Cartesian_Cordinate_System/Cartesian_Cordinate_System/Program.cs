using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartesian_Cordinate_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int output = 0;

            bool isPositiveX = x > 0;
            bool isPositiveY = y > 0;

            bool isZeroX = x == 0;
            bool isZeroY = y == 0;

            if (isPositiveX && isPositiveY)
            {
                output = 1;
            }
            else if (!isPositiveX && isPositiveY && !isZeroX)
            {
                output = 2;
            }
            else if (!isPositiveX && !isPositiveY && !isZeroX && !isZeroY)
            {
                output = 3;
            }
            else if (isPositiveX && !isPositiveY && !isZeroY)
            {
                output = 4;
            }
            else if (isZeroX && isPositiveY)
            {
                output = 5;
            }
            else if (isZeroX && !isPositiveY && !isZeroY)
            {
                output = 5;
            }
            else if (isPositiveX && isZeroY)
            {
                output = 6;
            }
            else if (!isPositiveX && isZeroY && !isZeroX)
            {
                output = 6;
            }

            Console.WriteLine(output);
        }
    }
}
