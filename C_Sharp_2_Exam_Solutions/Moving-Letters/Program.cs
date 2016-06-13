using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            var letterSeq = new StringBuilder();

            //get the length of the longest word in a string array using LINQ
            int maxLen = words.Max(w => w.Length);

            for (int i = 0; i < maxLen; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i < words[j].Length)
                    {
                        int len = words[j].Length - 1;
                        letterSeq.Append(words[j][len - i]);
                    }
                }
            }

            for (int i = 0; i < letterSeq.Length; i++)
            {
                int next = (i + ((char.ToLower(letterSeq[i]) - 'a') + 1)) % letterSeq.Length;

                char temp = letterSeq[i];

                letterSeq.Remove(i, 1);

                letterSeq.Insert(next, temp);
            }

            Console.WriteLine(letterSeq);
        }
    }
}
