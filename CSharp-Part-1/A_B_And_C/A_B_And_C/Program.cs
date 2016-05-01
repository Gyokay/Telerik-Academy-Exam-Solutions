using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_B_And_C
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long maxNumb = a;
            long minNumb = a;

            if (b > a && b > c)
            {
                maxNumb = b;
            }
            else if (c > a && c > b)
            {
                maxNumb = c;
            }

            if (b < a && b < c)
            {
                minNumb = b;
            }
            else if (c < a && c < b)
            {
                minNumb = c;
            }
            else if (b == c && a < b)
            {
                maxNumb = b;
            }
            else if (a > b && b == c)
            {
                minNumb = b;
            }

            double sum = a + b + c;
            double avg = sum / 3;

            Console.WriteLine(maxNumb);
            Console.WriteLine(minNumb);
            Console.WriteLine("{0:F3}", avg);
        }
    }
}
