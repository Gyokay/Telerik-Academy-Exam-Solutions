using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TRES4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger dec = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(ConvertFromDecimal(dec, 9));
        }

        static public string ConvertFromDecimal(BigInteger number, int numeralBase)
        {
            var words = new string[] {"LON+", "VK-", "*ACAD", "^MIM",
                                      "ERIK|", "SEY&", "EMY>>", "/TEL",
                                      "<<DON"};

            var output = new StringBuilder();

            if (number == 0) //handles --> number = 0
            {
                output.Insert(0, words[0]);
                return output.ToString();
            }

            while (number > 0)
            {
                BigInteger reminder = number % numeralBase;
                number /= numeralBase;

                output.Insert(0, words[(int)reminder]);
            }

            return output.ToString();
        }
    }
}
