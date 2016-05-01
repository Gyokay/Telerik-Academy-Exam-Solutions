using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Tribonacci_Triangle
{
    class Program
    {
        static void Main()
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNum = BigInteger.Parse(Console.ReadLine());
            int line = int.Parse(Console.ReadLine());
            List<BigInteger> seq = new List<BigInteger>();
            seq.Add(firstNum);
            seq.Add(secondNum);
            seq.Add(thirdNum);

            for (int i = 0; i < 210; i++)
            {
                BigInteger last = seq[seq.Count - 1];
                BigInteger mid = seq[seq.Count - 2];
                BigInteger first = seq[seq.Count - 3];
                BigInteger next = last + mid + first;

                seq.Add(next);
            }

            for (int i = 1; i <= line; i++)
            {
                StringBuilder currentLine = new StringBuilder();

                for (int j = 0; j < i; j++)
                {
                    currentLine.Append(seq[0]);
                    currentLine.Append(" ");
                    seq.RemoveAt(0);
                }

                Console.WriteLine(currentLine.ToString().Trim());
            }
        }
    }
}
