using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Digit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] counts = new int[n];
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                long num = long.Parse(Console.ReadLine());

                string bin = Convert.ToString(num, 2);

                for (int j = 0; j < bin.Length; j++)
                {
                    bool isB = bin[j] - '0' == b;

                    if (isB)
                    {
                        counter++;
                    }
                }

                counts[i] = counter;
                counter = 0;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(counts[i]);
            }
        }
    }
}
