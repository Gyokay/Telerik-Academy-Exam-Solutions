using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maslan
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<long> number = new List<long>();

            for (int i = 0; i < input.Length; i++)
            {
                number.Add(input[i] - '0');
            }

            long product = 1;
            long transformation = 0;

            while (number.Count > 1)
            {
                while (number.Count != 0)
                {
                    number.RemoveAt(number.Count - 1);
                    long currentSum = 0;

                    for (int i = 0; i < number.Count; i++)
                    {
                        if (i % 2 != 0)
                        {
                            currentSum += number[i];
                        }
                    }

                    if (currentSum != 0)
                    {
                        product *= currentSum;
                    }
                }

                transformation++;

                if (transformation < 10)
                {
                    string productString = product.ToString();

                    number.Clear();

                    for (int i = 0; i < productString.Length; i++)
                    {
                        number.Add(productString[i] - '0');
                    }
                    product = 1;
                }
                else
                {
                    Console.WriteLine(product);
                    break;
                }
            }

            if (transformation < 10)
            {
                Console.WriteLine(transformation);
                Console.WriteLine(number[0]);
            }
            
        }
    }
}
