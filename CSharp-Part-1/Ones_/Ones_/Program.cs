using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ones_And_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] zero = new string[] { "###", "#.#", "#.#", "#.#", "###" };
            string[] one = new string[] { ".#.", "##.", ".#.", ".#.", "###" };

            string bits = Convert.ToString(number, 2).PadLeft(16, '0');

            for (int i = 0; i < 5; i++)
            {
                for (int j = bits.Length - 16; j < bits.Length; j++)
                {
                    if (bits[j] == '0')
                    {
                        Console.Write(zero[i]);
                    }
                    else
                    {
                        Console.Write(one[i]);
                    }

                    if (j < bits.Length - 1)
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
