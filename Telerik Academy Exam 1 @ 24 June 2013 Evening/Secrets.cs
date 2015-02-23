using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Telerik_Academy_Exam_1___24_June_2013_Evening_Problem_2
{
    class Secrets
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger number = n;
            if (number < 0)
            {
                number *= -1;
            }
            int specialSum = 0;
            int position = 1;

            while (number > 0)
            {
                int digit = (int)(number % 10);
                number /= 10;

                if (position % 2 == 0)
                {
                    specialSum += digit * digit * position;
                }
                else
                {
                    specialSum += digit * position * position;
                }
                ++position;
            }
            Console.WriteLine(specialSum);
            int sequanceLength = specialSum % 10;
            if (sequanceLength == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", n);
            }
            int r = specialSum % 26;
            for (int i = 0; i < sequanceLength; i++)
            {
                Console.Write((char)('A' + (r + i) % 26));
            }
        }
    }
}
