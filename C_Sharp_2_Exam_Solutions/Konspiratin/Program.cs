using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konspiratin
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = new string[N];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }

            bool isInMethod = false;
            List<string> inMethodNames = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentLine = input[i];

                if (currentLine.Contains("static") || i == input.Length - 1)
                {
                    if (isInMethod)
                    {
                        isInMethod = false;
                        Console.Write("{0} -> ", inMethodNames.Count);
                        Console.Write(string.Join<string>(", ", inMethodNames));
                        inMethodNames.Clear();
                        inMethodNames.Clear();

                        Console.WriteLine();
                    }

                    if (!isInMethod && i < input.Length - 1)
                    {
                        isInMethod = true;
                        string methodName = GetMethodName(currentLine);
                        Console.Write(methodName + ' ' + "->" + ' ');
                    }
                }
                else if (isInMethod)
                {
                    List<string> invocedMethodNames = CollectMethodInvoces(currentLine);

                    for (int j = 0; j < invocedMethodNames.Count; j++)
                    {
                        inMethodNames.Add(invocedMethodNames[j]);
                    }
                    
                }

            }


        }

        static List<string> CollectMethodInvoces(string line)
        {
            line = line.Trim();
            var output = new List<string>();
            var methods = new StringBuilder();
            bool isDot = false;
            bool isVoid = false;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '.')
                {
                    isDot = true;
                }
                else if (isDot && line[i] != '(')
                {
                    methods.Append(line[i]);
                }
                else if (line[i] == '(' && isDot)
                {
                    isDot = false;
                    output.Add(methods.ToString());
                    methods.Clear();
                }
                else if (char.IsUpper(line[i]) && !isDot && i == 0)
                {
                    isVoid = true;
                }
                else if (isVoid)
                {
                    methods.Append(line[i]);
                }
                else if(isVoid && line[i] == '(')
                {
                    isVoid = false;
                    output.Add(methods.ToString());
                    methods.Clear();
                }
            }

            return output;
        }

        static string GetMethodName(string line)
        {
            return line.Split(new char[] { ' ', '(' }, StringSplitOptions.RemoveEmptyEntries)[2];
        }
    }
}
