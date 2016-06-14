using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] input = new string[N];

            for (int i = 0; i < N; i++)
            {
                input[i] = Console.ReadLine();
            }

            // remove multiple spaces

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Regex.Replace(input[i], @"\s+", " ");
            }



            // print
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
