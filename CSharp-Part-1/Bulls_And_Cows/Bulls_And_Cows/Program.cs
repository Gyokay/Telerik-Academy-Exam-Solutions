using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_And_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = int.Parse(Console.ReadLine());

            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());

            List<int> found = new List<int>();

            List<int> nums = new List<int>();

            nums.Add(1111);

            for (int i = 1; i < 8889; i++)
            {
                int nextNumb = nums[0] + i;

                if (nextNumb.ToString().Contains('0'))
                {
                    continue;
                }
                else
                {
                    nums.Add(nums[0] + i);
                }
            }

            for (int i = 0; i < nums.Count; i++)
            {
                StringBuilder currentNumber = new StringBuilder();
                currentNumber.Append(nums[i]);

                StringBuilder secret = new StringBuilder();
                secret.Append(secretNumber);

                int foundBulls = 0;
                int foundCows = 0;

                for (int j = 0; j < 4; j++)
                {
                    if (currentNumber[j] == secret[j])
                    {
                        currentNumber[j] = '.';
                        secret[j] = '.';
                    }
                }

                for (int j = 0; j < 4; j++)
                {
                    if (currentNumber[j] != '.')
                    {
                        int index = secret.ToString().IndexOf(currentNumber[j]);

                        if (index >= 0)
                        {
                            secret[index] = '-';
                        }
                    }
                }

                foreach (var item in secret.ToString())
                {
                    if (item == '.') foundBulls++;
                    else if (item == '-') foundCows++;
                }

                if (foundBulls == bulls && foundCows == cows)
                {
                    found.Add(nums[i]);
                }
            }

            found.Sort();

            if (found.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in found)
                {
                    Console.Write(item);
                    Console.Write(' ');
                }
            }
        }
    }
}
