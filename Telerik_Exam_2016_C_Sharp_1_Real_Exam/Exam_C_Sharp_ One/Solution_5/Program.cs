using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string n = Console.ReadLine();
            uint n = uint.Parse(Console.ReadLine());
            uint c = uint.Parse(Console.ReadLine());

            bool breaked = false;
            int maxUsableCombs = 1;
            uint result = 0;

            for (int i = 0; i < c; i++)
            {

                breaked = false;
                int currentUsableCombs = 0;
                uint currentNumber = uint.Parse(Console.ReadLine());


                for (int j = 0; j < 32; j++)
                {
                    if (currentNumber == 0)
                    {
                        breaked = true;
                        break;
                    }
                    if (IsBitSet(currentNumber, j) && !IsBitSet(n, j))
                    {
                        currentUsableCombs++;
                    }
                    else if (IsBitSet(currentNumber, j) && IsBitSet(n, j))
                    {
                        breaked = true;
                        break;
                    }
                }


                if (currentUsableCombs > maxUsableCombs && !breaked)
                {
                    result = currentNumber;
                }

            }


            Console.WriteLine(result);

        }

        static public bool IsBitSet(uint b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }
    }
}
