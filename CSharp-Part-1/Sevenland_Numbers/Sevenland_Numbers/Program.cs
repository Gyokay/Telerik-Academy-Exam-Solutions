using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevenland_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int foo = k;
            int lastDigit = foo % 10;
            foo /= 10;
            int secondToLastDigit = foo % 10;

            int output = k;

            if (k == 666)
            {
                output = 1000;
            }
            else if (lastDigit < 6)
            {
                output += 1;
            }
            else if (lastDigit == 6 && secondToLastDigit == 6)
            {
                output += 34;
            }
            else
            {
                output += 4;
            }

            Console.WriteLine(output);
        }
    }
}
