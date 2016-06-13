using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace De_cat_coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in words)
            {
                List<int> dec = new List<int>();

                foreach (var ch in item)
                {
                    dec.Add(ch - 'a');
                }

                var num = ConvertToDecimal(dec, 21);

                var numone = ConvertFromDecimal(num, 26);

                foreach (var n in numone)
                {
                    Console.Write((char)(n + 'a'));
                }

                Console.Write(' ');
            }

            Console.WriteLine();
        }
        static public List<BigInteger> ConvertFromDecimal(BigInteger number, int numeralBase)
        {
            List<BigInteger> output = new List<BigInteger>();

            if (number == 0) //handles --> number = 0
            {
                output.Add(0);
                return output;
            }

            while (number > 0)
            {
                BigInteger reminder = number % numeralBase;
                number /= numeralBase;

                output.Insert(0, reminder);
            }

            return output;
        }


        static BigInteger ConvertToDecimal(List<int> num, int numeralBase)
        {
            BigInteger result = 0;

            for (int i = 0; i < num.Count; i++)
            {
                result = num[i] + result * numeralBase;
            }

            return result;
        }
    }
}
