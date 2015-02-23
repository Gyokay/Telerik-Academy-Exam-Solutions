using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_Academy_Exam_1___5_December_2013_Evening_Problem_1
{
    class Program
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            decimal result = (decimal)a / b + (decimal)c / d;
            if (result >= 1)
            {
                Console.WriteLine("{0:0}", (long)result);
            }
            else
            {
                Console.WriteLine("{0:F22}", result);
            }
            Console.WriteLine("{0}/{1}", a * d + c * b, b * d);
        }
    }
}

