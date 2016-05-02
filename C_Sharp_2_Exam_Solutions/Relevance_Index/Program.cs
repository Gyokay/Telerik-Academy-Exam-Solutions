using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Relevance_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int l = int.Parse(Console.ReadLine());
            char[] splitCharacters = new char[] { ' ', ',', '.', '?', '!', ';', '-', ')', '(' };

            Dictionary<string[], int> paragraphs = new Dictionary<string[], int>();
            
            for (int i = 0; i < l; i++)
            {
                string inputString = Console.ReadLine();

                string[] currentParagraph = inputString.Split(splitCharacters, StringSplitOptions.RemoveEmptyEntries);

                ToUpperCase(currentParagraph, word);

                paragraphs.Add(currentParagraph, CountStringOccurrences(currentParagraph, word));
            }

            var items = from pair in paragraphs
                        orderby pair.Value descending
                        select pair;

            foreach (var item in items)
            {
                PrintStringArr(item.Key);
            }
        }

        public static int CountStringOccurrences(string[] stringArr, string word)
        {
            int count = 0;

            for (int i = 0; i < stringArr.Length; i++)
            {
                if (stringArr[i] == word.ToUpper())
                {
                    count++;
                }
            }

            return count;
        }

        static void ToUpperCase(string[] initialStringArr, string word)
        {
            for (int i = 0; i < initialStringArr.Length; i++)
            {
                if (string.Equals(initialStringArr[i], word, StringComparison.CurrentCultureIgnoreCase)) // case insensitive string comparison
                {
                    initialStringArr[i] = initialStringArr[i].ToUpper();
                }
            }
        }

        static void PrintStringArr(string[] strArr)
        {
            StringBuilder stringToPrint = new StringBuilder();

            for (int i = 0; i < strArr.Length; i++)
            {
                stringToPrint.Append(strArr[i]);

                if (i < strArr.Length - 1)
                {
                    stringToPrint.Append(" ");
                }
            }

            Console.WriteLine(stringToPrint);
        }
    }
}
