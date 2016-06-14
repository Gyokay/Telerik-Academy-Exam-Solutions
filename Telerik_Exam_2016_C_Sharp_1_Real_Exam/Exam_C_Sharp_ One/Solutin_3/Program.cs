using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutin_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ulong digits = 0;

            for (int i = 1; i <= n; i++)
            {
                string currentNum = i.ToString();
                ulong lent = (ulong)currentNum.Length;
                digits += lent;
            }

            Console.WriteLine(digits);
        }
    }
}
