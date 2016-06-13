using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            long[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();


            List<long> indices = new List<long>();
            bool[] used = new bool[N];
            bool isCycle = false;

            long index = 0;

            do
            {
                if (!used[index])
                {
                    indices.Add(index);
                    long temp = index;
                    index = arr[index];
                    used[temp] = true;
                }
                else
                {
                    isCycle = true;
                    break;
                }

            } while (index < arr.Length && index > 0);

            if (isCycle)
            {
                int openBracket = indices.IndexOf(index);


                for (int i = 0; i < indices.Count; i++)
                {
                    string current = indices[i] + " ";

                    if (i == openBracket - 1)
                    {
                        Console.Write(current.Trim());
                    }
                    else if (i == openBracket)
                    {
                        Console.Write('(' + current.Trim() + ' ');
                    }
                    else
                    {
                        if (i == indices.Count - 1)
                        {
                            Console.Write("{0})", current.Trim());
                        }
                        else
                        {
                            Console.Write(current);
                        }
                    }
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(string.Join(" ", indices));
            }
        }
    }
}
