using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searcha_In_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            byte S = byte.Parse(Console.ReadLine());
            byte N = byte.Parse(Console.ReadLine());

            string bits = Convert.ToString(S, 2).PadLeft(4, '0');

            int output = 0;

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());

                string numBits = Convert.ToString(number, 2).PadLeft(30, '0');

                output += CountStringOccurrences(numBits, bits);
            }

            Console.WriteLine(output);
        }

        static int CountStringOccurrences(string text, string pattern)
        {
            // Loop through all instances of the string 'text'.
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i++;
                count++;
            }
            return count;
        }
    }
}
