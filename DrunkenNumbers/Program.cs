using System;

    class Program
    {
        static void Main()
        {
            int n = 0;
            n = int.Parse(Console.ReadLine());
            int number = n;
            int digits = 0;
            long m = 0;
            long v = 0;
            for (int i = 0; i < n; i++)
            {
              long roundInfo = long.Parse(Console.ReadLine());
              //string roundInfo = Console.ReadLine(); finds the numer of the digits
              //int digits = rounInfo.Length;
              long tempRoundInfo = roundInfo;
              while (tempRoundInfo > 0)
              {
                  tempRoundInfo /= 10;
                  digits++;
              }
                
              if (digits % 2 == 0)
              {
                  for (int j = 0; j < digits / 2; j++)
                  {
                      v += roundInfo % 10;
                      roundInfo /= 10;
                  }
                  
                  for (int j = 0; j < digits / 2; j++)
                  {
                      m += roundInfo % 10;
                      roundInfo /= 10;
                  }
              }
              else
              {

              }
            }
            if (m>v)
            {
                Console.WriteLine();
            }
            else if (v< m)
            {
                Console.WriteLine();
            }
            else
            {

            }

        }
    }
