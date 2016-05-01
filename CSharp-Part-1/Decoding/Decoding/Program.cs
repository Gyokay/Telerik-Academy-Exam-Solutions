using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 0;

            foreach (char currentChar in input)
            {
                double result = 0;

                if (currentChar == '@')
                {
                    break;
                }

                if (char.IsLetter(currentChar))
                {
                    result = 1000 + (currentChar * salt);
                }
                else if (char.IsDigit(currentChar))
                {
                    result = currentChar + salt + 500;
                }
                else
                {
                    result = currentChar - salt;
                }

                if (counter % 2 == 0)
                {
                    result /= 100;
                    Console.WriteLine("{0:0.00}", result);
                }
                else
                {
                    result *= 100;
                    Console.WriteLine(result);
                }

                counter++;
            }
        }
    }
}
