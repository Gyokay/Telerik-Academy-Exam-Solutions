using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Strangeland_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            BigInteger resultDecimal = 0;

            int pow = FindNumberCount(input);

            for (int i = 0; i < input.Length; i++)
            {
                int digit = 0;

                if (char.IsLower(input[i]))
                {
                    switch (input[i])
                    {
                        case 'f': digit = 0; break;
                        case 'b': digit = 1; break;
                        case 'o': digit = 2; break;
                        case 'm': digit = 3; break;
                        case 'l': digit = 4; break;
                        case 'p': digit = 5; break;
                        case 'h': digit = 6; break;
                    }

                    resultDecimal += (BigInteger)Math.Pow(7, pow) * digit;

                    pow--;
                }
            }

            Console.WriteLine(resultDecimal);
        }

        static int FindNumberCount(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i])) count++;
            }

            return --count;
        }
    }
}
