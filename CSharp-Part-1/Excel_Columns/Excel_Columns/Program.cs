using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= N; i++)
            {
                char n = Console.ReadLine()[0];

                sum += Math.Pow(26, N - i) * (n - 64);
            }

            Console.WriteLine(sum);

        }
    }
}
