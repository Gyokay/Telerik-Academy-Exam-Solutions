using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1213
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (current == '@')
                {
                    break;
                }
                else if (alphabet.Contains(current))
                {

                    int index = alphabet.IndexOf(current);
                    if (index > 25)
                    {
                        index = index - 26;
                    }
                    result += index;
                }
                else if (numbers.Contains(current))
                {
                    int parsed = (int)Char.GetNumericValue(current);
                    result = result * parsed;
                }
                else
                {
                    result = result % m;
                }
            }
            Console.WriteLine(result);
        }
    }
}