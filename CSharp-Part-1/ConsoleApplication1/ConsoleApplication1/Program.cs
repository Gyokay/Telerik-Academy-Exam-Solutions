using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            BigInteger generalProductOne = 1;
            BigInteger generalProductTwo = 1;


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                ulong currentNumber = ulong.Parse(input);

                if (counter % 2 != 0)
                {
                    if (counter <= 9)
                    {
                        while (currentNumber > 0)
                        {
                            ulong lastDigit = currentNumber % 10;

                            if (lastDigit > 0)
                            {
                                generalProductOne *= lastDigit;
                            }

                            currentNumber /= 10;
                        }
                    }
                    else
                    {
                        while (currentNumber > 0)
                        {
                            ulong lastDigit = currentNumber % 10;

                            if (lastDigit > 0)
                            {
                                generalProductTwo *= lastDigit;
                            }

                            currentNumber /= 10;
                        }
                    }
                }

                counter++;
            }

            if (counter < 10)
            {
                Console.WriteLine(generalProductOne);
            }
            else
            {
                Console.WriteLine(generalProductOne);
                Console.WriteLine(generalProductTwo);
            }
        }
    }
}
