// 100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1._3_6_9_2013
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long r = 0;
            if (b == 3)
            {
                r = a + c;
            }
            else if (b == 6)
            {
                r = a * c;
            }
            else if (b == 9)
            {
                r = a % c;
            }

            if (r % 3 == 0)
            {
                Console.WriteLine(r / 3);
            }
            else
            {
                Console.WriteLine(r % 3);
                
            }
            
                Console.WriteLine(r);
                      
        }

    }
}
