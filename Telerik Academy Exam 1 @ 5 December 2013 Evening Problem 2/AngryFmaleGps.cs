// 100/100 alone
using System;

    class Angry_Fmale_Gps
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            if (n < 0)
            {
                n *= -1; 
            } 
            long number = n;
            long digit = 0;
            long oddSum = 0;
            long evenSum = 0;
            while (number > 0)
            {
                digit = number % 10;
                number /= 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
            }
            if (evenSum > oddSum)
            {
                Console.WriteLine("right {0}", evenSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("left {0}", oddSum);
            }
            else
            {
                Console.WriteLine("straight {0}", evenSum);
            }
        }
    }
