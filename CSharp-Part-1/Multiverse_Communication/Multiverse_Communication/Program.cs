using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiverse_Communication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arr = new string[] { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

            string code = "";

            double result = 0;

            while (input != string.Empty)
            {
                string currentString = input.Substring(0, 3);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (currentString == arr[i])
                    {
                        if (i == 10)
                        {
                            code += 'A';
                        }
                        else if (i == 11)
                        {
                            code += 'B';
                        }
                        else if (i == 12)
                        {
                            code += 'C';
                        }
                        else
                        {
                            code += i.ToString();
                        }

                        break;
                    }
                }

                input = input.Remove(0, 3);
            }

            for (int i = code.Length - 1; i >= 0; i--)
            {
                if (code[i] == 'A')
                {
                    result += Math.Pow(13, code.Length - i - 1) * 10;
                }
                else if (code[i] == 'B')
                {
                    result += Math.Pow(13, code.Length - i - 1) * 11;
                }
                else if (code[i] == 'C')
                {
                    result += Math.Pow(13, code.Length - i - 1) * 12;
                }
                else
                {
                    result += Math.Pow(13, code.Length - i - 1) * (code[i] - '0');
                }
            }

            Console.WriteLine(result);
        }
    }
}
