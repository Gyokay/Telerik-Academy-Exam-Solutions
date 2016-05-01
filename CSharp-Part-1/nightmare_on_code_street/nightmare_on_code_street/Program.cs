using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nightmare_on_code_street
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            long sum = 0;
            long digitCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    if (i % 2 != 0)
                    {
                        sum += input[i] - '0';
                        digitCount++;
                    }
                }
               
            }

            //Console.Write(digitCount);
            //Console.Write(' ');
            //Console.Write(sum);

                //or

            Console.WriteLine("{0} {1}", digitCount, sum);



        }
    }
}
