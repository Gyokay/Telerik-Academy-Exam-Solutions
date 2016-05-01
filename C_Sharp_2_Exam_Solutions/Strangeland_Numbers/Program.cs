using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strangeland_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<long> digits = ConvertToDigit(input);

            Console.WriteLine(ConvertToDecimal(digits, 7));
        }

        static public List<long> ConvertToDigit(string input)
        {
            string[] words = new string[] { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };

            List<long> digits = new List<long>();

            int startIndex = 0;
            int length = 1;

            while (startIndex < input.Length)
            {
                string stringToCheck = input.Substring(startIndex, length);

                bool matchFound = false;

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == stringToCheck)
                    {
                        digits.Add(i);
                        matchFound = true;
                        break;
                    }
                }

                if (matchFound)
                {
                    startIndex += length;
                    length = 1;
                }
                else
                {
                    length++;
                }
            }

            return digits;
        }

        static public double ConvertToDecimal(List<long> digits, long numeralBase)
        {
            double number = 0;

            for (int i = 0; i < digits.Count; i++)
            {
                number += Math.Pow(numeralBase, (digits.Count - i) - 1) * digits[i];
            }

            return number;
        }
    }
}
