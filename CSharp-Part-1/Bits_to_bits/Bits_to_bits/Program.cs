using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits_to_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            StringBuilder concat = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                long numb = long.Parse(Console.ReadLine());
                string bin = Convert.ToString(numb, 2);

                if (bin.Length < 30)
                {
                    string zeros = new string('0', 30 - bin.Length);
                    bin = bin.Insert(0, zeros);
                }
                else
                {
                    int charPosition = bin.Length - 30;
                    bin = bin.Substring(charPosition);
                }

                concat.Append(bin);
            }

            int maxZero = 0;
            int maxOne = 0;
            int current = 1;



            for (int i = 0; i < concat.Length - 1; i++)
            {
                if (concat[i] == concat[i + 1] && concat[i] == '0')
                {
                    current++;
                    if (current > maxZero)
                    {
                        maxZero = current;
                    }
                }
                else
                {
                    current = 1;
                }
            }

            current = 1;

            for (int i = 0; i < concat.Length - 1; i++)
            {
                if (concat[i] == concat[i + 1] && concat[i] == '1')
                {
                    current++;
                    if (current > maxOne)
                    {
                        maxOne = current;
                    }
                }
                else
                {
                    current = 1;
                }
            }

            Console.WriteLine(maxZero);
            Console.WriteLine(maxOne);
        }
    }
}
