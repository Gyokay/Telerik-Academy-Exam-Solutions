using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_Rotation_Of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> foo = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                foo.Add(input[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                if (foo[foo.Count - 1] != '0')
                {
                    foo.Insert(0, foo[foo.Count - 1]);
                }

                foo.RemoveAt(foo.Count - 1);
            }

            for (int i = 0; i < foo.Count; i++)
            {
                Console.Write(foo[i]);
            }

            Console.WriteLine();
        }
    }
}
