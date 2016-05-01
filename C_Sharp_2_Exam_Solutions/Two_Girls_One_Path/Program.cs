using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Two_Girls_One_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var split = input.Split(' ');

            long[] path = new long[split.Length];

            for (int i = 0; i < split.Length; i++)
            {
                path[i] = long.Parse(split[i]);
            }

            int pathLen = path.Length;

            BigInteger scoreMolly = path[0];
            BigInteger scoreDolly = path[pathLen - 1];


            long currentIndexMolly = 0;
            long nextIncrementMolly = currentIndexMolly + path[currentIndexMolly];

            long currentIndexDolly = pathLen - 1;
            long nextIncrementDolly = currentIndexDolly - path[currentIndexDolly];

            while (currentIndexMolly < nextIncrementMolly && currentIndexDolly > nextIncrementDolly)
            {
                long nextIndexMolly = FindNextIndexMolly(pathLen, nextIncrementMolly);
                long nextIndexDolly = FindNextIndexDolly(pathLen, nextIncrementDolly);

                if (nextIndexMolly == nextIndexDolly)
                {
                    scoreMolly += path[nextIndexMolly] / 2;
                    scoreDolly += path[nextIndexMolly] / 2;

                    if (path[nextIndexMolly] % 2 == 0)
                    {
                        var tempMolly = path[nextIndexMolly];
                        path[nextIndexMolly] = 0;
                        currentIndexMolly = nextIndexMolly;
                        nextIncrementMolly = currentIndexMolly + tempMolly;
                    }
                    else
                    {
                        var tempDolly = path[nextIndexDolly];
                        path[nextIndexMolly] = 1;
                        currentIndexDolly = nextIndexDolly;
                        nextIncrementDolly = currentIndexDolly - tempDolly;
                    }
                }
                else
                {
                    scoreMolly += path[nextIndexMolly];
                    var tempMolly = path[nextIndexMolly];
                    path[nextIndexMolly] = 0;
                    currentIndexMolly = nextIndexMolly;
                    nextIncrementMolly = currentIndexMolly + tempMolly;

                    scoreDolly += path[nextIndexDolly];
                    var tempDolly = path[nextIndexDolly];
                    path[nextIndexDolly] = 0;
                    currentIndexDolly = nextIndexDolly;
                    nextIncrementDolly = currentIndexDolly - tempDolly;
                }
            }

            if (currentIndexMolly == nextIncrementMolly && currentIndexDolly == nextIncrementDolly)
            {
                Console.WriteLine("Draw");
            }
            else
            {
                //On the first line write down the girl, who did not reach an empty cell
                if (currentIndexMolly == nextIncrementMolly)
                {
                    var foo = FindNextIndexDolly(pathLen, nextIncrementDolly);
                    scoreDolly += path[foo];
                    Console.WriteLine("Dolly");
                }
                else
                {
                    var foo = FindNextIndexMolly(pathLen, nextIncrementMolly);
                    scoreMolly += path[foo];
                    Console.WriteLine("Molly");
                } 
            }

            Console.WriteLine("{0} {1}", scoreMolly, scoreDolly);

        }

        static public long FindNextIndexMolly(int arrLength, long nextIncrementMolly)
        {
            while (nextIncrementMolly > arrLength - 1)
            {
                nextIncrementMolly -= arrLength;
            }

            return nextIncrementMolly;
        }

        static private long FindNextIndexDolly(int arrLength, long nextIndexDolly)
        {
            while (nextIndexDolly < 0)
            {
                nextIndexDolly += arrLength;
            }

            return nextIndexDolly;
        }
    }
}
