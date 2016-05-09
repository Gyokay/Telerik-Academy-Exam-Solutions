using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Durankulak_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] letters = new string[168];

            FillLetters(letters);


            List<int> toDecimal = new List<int>();

            StringBuilder current = new StringBuilder();

            bool isGroup = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    current.Append(input[i]);
                    isGroup = true;
                }
                else if (char.IsUpper(input[i]) && isGroup)
                {
                    current.Append(input[i]);
                    toDecimal.Add(Array.IndexOf(letters, current.ToString()));
                    isGroup = false;
                    current.Clear();
                }
                else
                {
                    toDecimal.Add(Array.IndexOf(letters, input[i].ToString()));
                }
            }

            Console.WriteLine(ConvertToDecimal(toDecimal, 168));
        }

        static public BigInteger ConvertToDecimal(List<int> digits, int numeralBase)
        {
            BigInteger number = 0;

            for (int i = 0; i < digits.Count; i++)
            {
                number += BigInteger.Pow(numeralBase, (digits.Count - i) - 1) * digits[i];
            }

            return number;
        }

        static void FillLetters(string[] letters)
        {
            int index = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                letters[index++] = i.ToString();
            }

            bool toBreak = false;
            for (char i = 'a'; i <= 'z'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    if (index == 168)
                    {
                        toBreak = true;
                        break;
                    }

                    letters[index++] = i.ToString() + j;
                }

                if (toBreak)
                {
                    break;
                }
            }
        }
    }
}
