using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miss_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cats = new int[10];
            int maxVote = 0;
            int winner = 0;

            long n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentVote = int.Parse(Console.ReadLine());

                cats[currentVote - 1]++; 
            }

            for (int i = 0; i < cats.Length; i++)
            {
                if (cats[i] > maxVote)
                {
                    maxVote = cats[i];
                    winner = i;
                }
            }

            Console.WriteLine(winner += 1);
        }
    }
}
