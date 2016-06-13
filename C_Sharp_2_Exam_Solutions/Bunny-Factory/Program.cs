using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Bunny_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialArr = new List<int>();
            while (true)
            {
                string current = Console.ReadLine();
                if (current == "END")
                {
                    break;
                }

                initialArr.Add(int.Parse(current));
            }

            int index = 1;
            while (true)
            {
                if (index > initialArr.Count)
                {
                    break;
                }

                int initialSum = 0;
                for (int i = 0; i < index; i++)
                {
                    initialSum += initialArr[i];
                }

                if (initialArr.Count < index + initialSum)
                {
                    break;
                }

                BigInteger nextSum = 0;
                BigInteger prod = 1;
                for (int i = index; i < index + initialSum; i++)
                {
                    nextSum += initialArr[i];
                    prod *= initialArr[i];
                }

                StringBuilder concat = new StringBuilder();
                concat.Append(nextSum);
                concat.Append(prod);

                for (int i = index + initialSum; i < initialArr.Count; i++)
                {
                    concat.Append(initialArr[i]);
                }

                initialArr.Clear();

                foreach (char item in concat.ToString())
                {
                    if (item != '0' && item != '1')
                    {
                        initialArr.Add(int.Parse(item.ToString()));
                    }
                }

                index++;
            }

            Console.WriteLine(string.Join(" ", initialArr));
        }
    }
}
