using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] input = new string[N];

            for (int i = 0; i < N; i++)
            {
                input[i] = Console.ReadLine();
            }

            List<string> output = new List<string>();
            bool indentate = false;

            Trim(input);

            bool inScope = false;

            for (int i = 0; i < input.Length; i++)
            {
                string currenLine = input[i];

                if ((currenLine.Contains("function") || currenLine.Contains("while") || currenLine.Contains("for") || currenLine.Contains("if"))  && !inScope)
                {
                    inScope = true;
                    output.Add(currenLine);




                    continue;
                }
                else if (inScope && !currenLine.Contains('}'))
                {
                    currenLine = "    " + currenLine;
                    output.Add(currenLine);
                }
                else if (currenLine.Contains('}'))
                {
                    inScope = false;
                    output.Add(currenLine);
                }
            }











            for (int i = 0; i < input.Length; i++)
            {
                string currentLine = input[i];

                if (string.IsNullOrWhiteSpace(currentLine) || string.IsNullOrEmpty(currentLine))
                {
                    continue;
                }


                if (indentate)
                {
                    Indentate(currentLine);
                }



                if (currentLine.Contains('{'))
                {
                    indentate = true;
                }



                //output.Append(currentLine);
                Console.WriteLine(currentLine);

            }



        }
        static void Trim(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim();
            }
        }



        static StringBuilder ReplaceMultipleSpaces(string s)
        {
            var output = new StringBuilder();
            s = s.Trim();

            bool isSpace = false; //if false append
            bool isInRounBrackets = false;

            for (int i = 0; i < s.Length; i++)
            {
                //TO DO: must handle situations with multiple parameters in the rounded brackets

                char currentCh = s[i];

                if (currentCh == '(')
                {
                    isInRounBrackets = true;
                }

                if (currentCh == ' ' && isSpace && isInRounBrackets)
                {
                    continue;
                }
                else if (currentCh == ' ' && !isSpace && !isInRounBrackets)
                {
                    output.Append(currentCh);
                    isSpace = true;
                }
                else if (currentCh != ' ')
                {
                    output.Append(currentCh);
                }

            }

            //AddSpace(output);

            return output;
        }

        static bool IsLineEmpty(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    return false;
                }
            }

            return true;
        }

        static void AddSpace(StringBuilder s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '+' || s[i] == '-' || s[i] == '=' || s[i] == '<' || s[i] == '>' || s[i] == '!')
                {
                    if (s[i - 1] != ' ')
                    {
                        s.Insert(i - 1, ' ');
                    }

                    if (s[i + 1] != ' ')
                    {
                        s.Insert(i + 1, ' ');
                    }
                }
            }
        }

        static void Indentate(string s)
        {
            s.Trim();
            s = s + "    ";
        }
    }
}
