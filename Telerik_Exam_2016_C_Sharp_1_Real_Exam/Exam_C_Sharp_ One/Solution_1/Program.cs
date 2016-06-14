using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());

            double avg = f / b;
            double result = 0;

            if (b % 2 == 0)
            {
                result = avg * 123123123123;
            }
            else
            {
                result = avg / 317;
            }

            Console.WriteLine("{0:0.0000}", result);
        }
    }
}
