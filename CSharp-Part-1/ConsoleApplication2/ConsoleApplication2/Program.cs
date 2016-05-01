using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ulong> numbers = new List<ulong>();

            while (true)
            {
                ulong currentNumber;
                bool parsed = ulong.TryParse(Console.ReadLine(), out currentNumber);

                if (parsed)
                {
                    numbers.Add(currentNumber);
                }
                else
                {
                    break;
                }
            }

            BigInteger firstTenProd = 1;
            BigInteger afterTenProd = 1;

            if (numbers.Count > 10)
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (i % 2 == 0)
                    {
                        BigInteger currentProd = 1;
                        ulong currentNum = numbers[i];

                        while (currentNum > 0)
                        {
                            ulong lastDigit = currentNum % 10;

                            if (lastDigit > 0)
                            {
                                currentProd *= lastDigit;
                            }
                            currentNum /= 10;
                        }

                        firstTenProd *= currentProd;
                    }
                }

                for (int i = 10; i < numbers.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        BigInteger currentProd = 1;
                        ulong currentNum = numbers[i];

                        while (currentNum > 0)
                        {
                            ulong lastDigit = currentNum % 10;

                            if (lastDigit > 0)
                            {
                                currentProd *= lastDigit;
                            }
                            currentNum /= 10;
                        }

                        afterTenProd *= currentProd;
                    }
                }

                Console.WriteLine(firstTenProd);
                Console.WriteLine(afterTenProd);
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        BigInteger currentProd = 1;
                        ulong currentNum = numbers[i];

                        while (currentNum > 0)
                        {
                            ulong lastDigit = currentNum % 10;

                            if (lastDigit > 0)
                            {
                                currentProd *= lastDigit;
                            }
                            currentNum /= 10;
                        }

                        firstTenProd *= currentProd;
                    }
                }
                Console.WriteLine(firstTenProd);
            }

        }
    }
}
