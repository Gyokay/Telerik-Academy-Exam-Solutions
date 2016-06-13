using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joro_The_Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int bestPath = 0;

            for (int start = 0; start < numbers.Length; start++)
            {
                for (int step = 1; step <= numbers.Length; step++)
                {
                    int currentPath = 1;
                    int index = start;
                    int next = index + step;
                    if (next >= numbers.Length)
                    {
                        next -= numbers.Length;
                    }

                    while (numbers[index] < numbers[next])
                    {
                        currentPath++;
                        index = next;
                        next = (index + step) % numbers.Length;
                    }

                    bestPath = Math.Max(bestPath, currentPath);
                }
            }

            Console.WriteLine(bestPath);
        }
    }
}
