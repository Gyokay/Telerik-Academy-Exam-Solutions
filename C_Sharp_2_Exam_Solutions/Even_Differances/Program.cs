using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Even_Differances
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] seqanceStr = input.Split(' ');
            BigInteger result = 0;

            long[] seq = new long[seqanceStr.Length];

            for (int i = 0; i < seqanceStr.Length; i++)
            {
                seq[i] = long.Parse(seqanceStr[i]);
            }

            for (int i = 1; i < seq.Length; i++)
            {
                long a = seq[i - 1];
                long b = seq[i];
                long difference = 0;

                if (a > b)
                {
                    difference = a - b;
                }
                else
                {
                    difference = b - a;
                }

                if (difference % 2 == 0)
                {
                    result += difference;
                    i++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
