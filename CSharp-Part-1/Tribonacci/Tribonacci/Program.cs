using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger T1 = BigInteger.Parse(Console.ReadLine());
        BigInteger T2 = BigInteger.Parse(Console.ReadLine());
        BigInteger T3 = BigInteger.Parse(Console.ReadLine());

        long N = long.Parse(Console.ReadLine());

        if (N == 1)
        {
            Console.WriteLine(T1);
        }
        else if (N == 2)
        {
            Console.WriteLine(T2);
        }
        else if (N == 3)
        {
            Console.WriteLine(T3);
        }

        for (int i = 3; i < N; i++)
        {
            BigInteger tempT1 = T1;
            BigInteger tempT2 = T2;

            T1 = T2;
            T2 = T3;
            T3 = tempT1 + tempT2 + T3;
        }

        if (N > 3)
        {
            Console.WriteLine(T3);
        }
    }
}

