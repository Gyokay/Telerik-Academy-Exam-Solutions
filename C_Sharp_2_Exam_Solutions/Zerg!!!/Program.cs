using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Zerg___
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] codes = new string[] { "Rawr", "Rrrr", "Hsst", "Ssst",
                                            "Grrr", "Rarr", "Mrrr", "Psst",
                                            "Uaah", "Uaha", "Zzzz", "Bauu",
                                            "Djav", "Myau", "Gruh" };

            List <int> toDec = new List<int>();

            bool isGroup = false;
            StringBuilder currentCode = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]) && !isGroup)
                {
                    currentCode.Append(input[i]);
                    isGroup = true;
                }
                else if (char.IsLower(input[i]) && isGroup)
                {
                    currentCode.Append(input[i]);

                    if (i == input.Length - 1)
                    {
                        toDec.Add(Array.IndexOf(codes, currentCode.ToString()));
                        break;
                    }

                    continue;
                }
                else if (char.IsUpper(input[i]) && isGroup)
                {
                    toDec.Add(Array.IndexOf(codes, currentCode.ToString()));
                    currentCode.Clear();
                    currentCode.Append(input[i]);
                }
            }

            BigInteger dec = ConvertToDecimal(toDec, 15);


            Console.WriteLine(dec);
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
    }
}
