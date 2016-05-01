using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace We_All_Love_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                long numb = long.Parse(Console.ReadLine());

                long firstTransformation = ~numb;

                // converts the integer to binary string, reverses the string and converts it back to integer
                string transform = Convert.ToString(numb, 2);
                char[] charArr = transform.ToCharArray();
                Array.Reverse(charArr);
                transform = new string(charArr);
                long secondTransformation = Convert.ToInt32(transform, 2);

                long output = (numb ^ firstTransformation) & secondTransformation;

                Console.WriteLine(output);
            }
        }
    }
}
