using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            int[] arr = new int[c];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int groups = 1;
            int maxSpeed = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                int currentBus = arr[i];

                if (currentBus > maxSpeed)
                {
                    continue;
                }
                else if (currentBus < maxSpeed)
                {
                    groups++;
                    maxSpeed = currentBus;
                    continue;
                }
                else if (maxSpeed == currentBus)
                {
                    groups++;
                    continue;
                }
            }

            Console.WriteLine(groups);

        }
    }
}
