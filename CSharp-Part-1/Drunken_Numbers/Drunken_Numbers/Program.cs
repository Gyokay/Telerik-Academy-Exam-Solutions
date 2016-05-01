using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drunken_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long scoreM = 0;
            long scoreV = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input = input.TrimStart('0', '-');
                long[] currenNumb = new long[input.Length];

                //put current score to an array
                for (int j = 0; j < currenNumb.Length; j++)
                {
                    currenNumb[j] = int.Parse(input[j].ToString());
                }

                if (currenNumb.Length % 2 != 0)
                {
                    for (int h = 0; h < currenNumb.Length; h++)
                    {
                        if (h <= currenNumb.Length / 2)
                        {
                            scoreM += currenNumb[h];

                            if (currenNumb.Length / 2 == h)
                            {
                                scoreV += currenNumb[h];
                            }
                        }
                        else if (h >= currenNumb.Length / 2)
                        {
                            scoreV += currenNumb[h];
                        }
                    }
                }
                else
                {
                    for (int h = 0; h < currenNumb.Length; h++)
                    {
                        if (h <= currenNumb.Length / 2 - 1)
                        {
                            scoreM += currenNumb[h];
                        }
                        else if (h >= currenNumb.Length / 2)
                        {
                            scoreV += currenNumb[h];
                        }
                    }
                }
            }

            if (scoreM == scoreV)
            {
                Console.WriteLine("No {0}", scoreV + scoreM);
            }
            else
            {
                if (scoreV > scoreM)
                {
                    Console.WriteLine("V {0}", scoreV - scoreM);
                }
                else
                {
                    Console.WriteLine("M {0}", scoreM - scoreV);
                }
            }

        }
    }
}
