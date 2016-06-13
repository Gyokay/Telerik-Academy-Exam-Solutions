using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Variable_Length_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. red the input
            // 2. convert each number to binary
            // 2.1. concatanate binary string
            // 2.2. trim zeroes at the end
            // 3. count the "1"'s and find the coresponding char
            // 4. output the result

            int[] initialNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int L = int.Parse(Console.ReadLine());

            var codeTable = new Dictionary<int, char>();

            for (int i = 0; i < L; i++)
            {
                string current = Console.ReadLine();
                var key = new StringBuilder();

                for (int j = 1; j < current.Length; j++)
                {
                    key.Append(current[j]);
                }

                codeTable.Add(int.Parse(key.ToString()), current[0]);
            }



            var binaryStringBuilder = new StringBuilder();
            for (int i = 0; i < initialNumbers.Length; i++)
            {
                binaryStringBuilder.Append(Convert.ToString(initialNumbers[i], 2).PadLeft(8, '0'));
            }

            string binaryString = binaryStringBuilder.ToString().TrimEnd('0');

            string[] frequency = binaryString.Split('0');


            var result = new StringBuilder();

            for (int i = 0; i < frequency.Length; i++)
            {
                int frequencyIndex = frequency[i].Length;

                result.Append(codeTable[frequencyIndex]);
            }

            Console.WriteLine(result);
        }
    }
}
