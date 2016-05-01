using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> words = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string currentWord = Console.ReadLine();
                words.Add(currentWord);
            }

            for (int i = 0; i < n; i++)
            {
                int nextIndex = words[i].Length % (n + 1);
                string wordToMove = words[i];

                words.Insert(nextIndex, wordToMove);

                if (nextIndex < i)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.RemoveAt(i);
                }

                
            }

            // print

            int maxLength = 0;

            foreach (string word in words)
            {
                maxLength = Math.Max(maxLength, word.Length);
            }


            StringBuilder output = new StringBuilder();

            for (int i = 0; i < maxLength; i++)
            {
                foreach (string word in words)
                {
                    if (word.Length > i)
                    {
                        output.Append(word[i]);
                    }
                }
            }

            Console.WriteLine(output);

        }
    }
}
