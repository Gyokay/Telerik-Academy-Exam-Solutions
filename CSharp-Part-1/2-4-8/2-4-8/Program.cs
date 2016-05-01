using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long result = 0;

            if (b == 2)
            {
                result = a % c;
            }
            else if (b == 4)
            {
                 result = a + c;
            }
            else if (b == 8)
            {
                result = a * c;
            }

            if (result % 4 == 0)
            {
                Console.WriteLine(result / 4);
            }
            else
            {
                Console.WriteLine(result % 4);
            }

            Console.WriteLine(result);
        }
    }
}
