using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<double> results = new List<double>();

            int startPosition = 0;

            while (true)
            {
                string currentDirections = Console.ReadLine();

                if (currentDirections == "stop")
                {
                    break;
                }

                string[] directions = currentDirections.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                double currentSum = 0;



                int times = int.Parse(directions[0]);
                int steps = int.Parse(directions[2]);
                for (int i = 0; i < times; i++)
                {
                    if (directions[1] == "right")
                    {
                        int nextIndex = (startPosition + steps) % input.Length;
                        currentSum += input[nextIndex];
                        startPosition = nextIndex;
                    }
                    else if (directions[1] == "left")
                    {
                        int nextIndex = (startPosition - steps) % input.Length;
                        if (nextIndex < 0)
                        {
                            nextIndex += input.Length;
                        }

                        currentSum += input[nextIndex];
                        startPosition = nextIndex;
                    }
                }

                results.Add(currentSum);
            }

            double output = 0;

            for (int i = 0; i < results.Count; i++)
            {
                output += results[i];
            }

            output /= results.Count;

            Console.WriteLine("{0:0.0}", output);
        }
    }
}
