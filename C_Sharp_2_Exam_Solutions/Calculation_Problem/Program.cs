using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = ConvertToDecimal(input);

            var output = ConvertToSomeBase((int)result, 23);

            var alphabet = new char[23];

            for (int i = 0; i < 23; i++)
            {
                alphabet[i] = (char)(97 + i);
            }

            string foo = "";

            for (int i = 0; i < output.Count; i++)
            {
                foo += alphabet[(int)output[i]];
            }

            Console.WriteLine("{0} = {1}", foo, result);

        }

        public static double ConvertToDecimal(string input)
        {
            var strArr = input.Split(' ');

            double result = 0;

            var alphabet = new char[23];

            for (int i = 0; i < 23; i++)
            {
                alphabet[i] = (char)(97 + i);
            }

            for (int i = 0; i < strArr.Length; i++)
            {
                for (int j = 0; j < strArr[i].ToString().Length; j++)
                {
                    int index = Array.IndexOf(alphabet, strArr[i].ToString()[j]);

                    result += index * Math.Pow(23, strArr[i].Length - (j + 1));
                }
            }

            return result;
        }

        public static List<int> ConvertToSomeBase(int number, int numeralBase)
        {
            List<int> output = new List<int>();

            while (number > 0)
            {
                int reminder = number % numeralBase;
                number /= numeralBase;

                output.Insert(0, reminder);
            }

            return output;
        }
    }
}
