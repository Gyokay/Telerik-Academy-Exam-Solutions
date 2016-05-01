using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Saddy_Kooper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> number = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                number.Add(input[i] - '0');
            }

            int transformations = 0;


            while (number.Count > 1)
            {
                string prod = findProduct(number).ToString();

                number.Clear();

                for (int i = 0; i < prod.Length; i++)
                {
                    number.Add(prod[i] - '0');
                }

                transformations++;

                if (transformations == 10)
                {
                    foreach (int item in number)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    break;
                }
            }

            if (number.Count == 1)
            {
                Console.WriteLine(transformations);
                Console.WriteLine(number[0]);
            }


        }

        static BigInteger findProduct(List<int> number)
        {
            List<int> sums = new List<int>();

            while (number.Count > 1)
            {
                int lastIndex = number.Count - 1;
                number.RemoveAt(lastIndex);


                int currentSum = 0;
                for (int i = 0; i < number.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        currentSum += number[i];
                    }
                }

                sums.Add(currentSum);
            }

            BigInteger products = 1;


            for (int i = 0; i < sums.Count; i++)
            {
                products *= sums[i];
            }

            return products;
        }
    }
}
