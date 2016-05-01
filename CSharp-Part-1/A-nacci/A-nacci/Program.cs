using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_nacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            int L = int.Parse(Console.ReadLine());

            int a = inputOne[0] - 64;
            int b = inputTwo[0] - 64;

            Console.WriteLine(inputOne);

            if (L > 1 && (a + b) <= 26)
            {
                Console.WriteLine("{0}{1}", inputTwo, (char)(a + b + 64));
                a = inputTwo[0] - 64;
                b = inputOne[0] - 64 + inputTwo[0] - 64;
            }
            else if (L != 1 && (a + b) > 26)
            {
                Console.WriteLine("{0}{1}", inputTwo, (char)(((a + b) % 26) + 64));
                a = inputTwo[0] - 64;
                b = (inputOne[0] - 64 + inputTwo[0] - 64) % 26;
            }


            for (int i = 2; i < L; i++)
            {
                string space = new string(' ', i - 1);

                if (a + b <= 26)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;

                    Console.Write((char)(b + 64));
                    Console.Write(space);
                }
                else
                {
                    int temp = a;
                    a = b;
                    b = (temp + b) % 26;

                    Console.Write((char)(b + 64));
                    Console.Write(space);
                }

                if (a + b <= 26)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;

                    Console.Write((char)(b + 64));
                    Console.WriteLine();
                }
                else
                {
                    int temp = a;
                    a = b;
                    b = (temp + b) % 26;

                    Console.Write((char)(b + 64));
                    Console.WriteLine();
                }

            }
        }
    }
}
