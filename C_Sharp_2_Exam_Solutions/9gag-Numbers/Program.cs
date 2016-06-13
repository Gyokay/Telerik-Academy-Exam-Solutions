using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _9gag_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numeralBase = 9;

            List<int> number = new List<int>();
            int indexStart = 0;
            int length = 1;

            while (indexStart < input.Length)
            {
                int currentNum = StringToNumber(input.Substring(indexStart, length));

                if (currentNum != -1)
                {
                    number.Add(currentNum);
                    indexStart += length;
                    length = 1; 
                }
                else
                {
                    length++;
                }
            }

            BigInteger decNum = ConvertToDecimal(number, numeralBase);

            Console.WriteLine(decNum);
            
        }
        // convert from any base TO Decimal
        static public BigInteger ConvertToDecimal(List<int> digits, int numeralBase)
        {
            BigInteger number = 0;

            for (int i = 0; i < digits.Count; i++)
            {
                number += BigInteger.Pow(numeralBase, (digits.Count - i) - 1) * digits[i];
            }

            return number;
        }

        static int StringToNumber(string s)
        {
            if (s == "-!") return 0;
            else if (s == "**") return 1;
            else if (s == "!!!") return 2;
            else if (s == "&&") return 3;
            else if (s == "&-") return 4;
            else if (s == "!-") return 5;
            else if (s == "*!!!") return 6;
            else if (s == "&*!") return 7;
            else if(s == "!!**!-") return 8;
            else return -1;
        }
    }
}
