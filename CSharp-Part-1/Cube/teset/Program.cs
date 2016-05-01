using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = new string(':', n);
            string slashes = new string('/', n - 2);
            int reverseEx = 4;
            char colon = ':';
            string space = new string(' ', n - 2);

            for (int i = 1; i <= (n * 2) - 1 ; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(line.PadLeft(n + (n - i), ' '));
                }

                else if (i == 2)
                {
                    StringBuilder secondLine = new StringBuilder();
                    secondLine.Append(':'.ToString().PadLeft(n - 1, ' '));
                    secondLine.Append(slashes);
                    secondLine.Append("::");
                    Console.WriteLine(secondLine);
                }
                else if (i > 2 && i < n)
                {
                    string ex = new string('X', i - 2);
                    StringBuilder someLine = new StringBuilder();
                    someLine.Append(':'.ToString().PadLeft((n - i) + 1, ' '));
                    someLine.Append(slashes);
                    someLine.Append(':');
                    someLine.Append(ex);
                    someLine.Append(':');

                    Console.WriteLine(someLine);
                }
                else if (i == n)
                {
                    string ex = new string('X', i - 2);
                    StringBuilder someLine = new StringBuilder();
                    someLine.Append(line);
                    someLine.Append(ex);
                    someLine.Append(':');

                    Console.WriteLine(someLine);
                }
                else if (i > n && i < (n * 2) - 2 )
                {
                    string ex = new string('X', i - reverseEx);
                    StringBuilder currentLine = new StringBuilder();
                    currentLine.Append(colon);
                    currentLine.Append(space);
                    currentLine.Append(colon);
                    currentLine.Append(ex);
                    currentLine.Append(colon);

                    reverseEx += 2;

                    Console.WriteLine(currentLine);
                }
                else if (i == (n * 2) - 2)
                {
                    StringBuilder currentLine = new StringBuilder();
                    currentLine.Append(colon);
                    currentLine.Append(space);
                    currentLine.Append(colon);
                    currentLine.Append(colon);

                    Console.WriteLine(currentLine);
                }
                else if (i == (n * 2) - 1)
                {
                    string lastLine = new string(':', n);

                    Console.WriteLine(lastLine);
                }
            }
        }
    }
}
