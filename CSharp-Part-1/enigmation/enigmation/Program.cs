using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigmation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = 0;
            int bracketsResult = 0;
            char currentOperator = '+';
            char bracketsOperstor = '+';
            bool inBrackets = false;

            foreach (char currenChar in input)
            {
                if (char.IsDigit(currenChar))
                {
                    if (inBrackets)
                    {
                        switch (bracketsOperstor)
                        {
                            case '+': bracketsResult += currenChar - '0'; break;
                            case '-': bracketsResult -= currenChar - '0'; break;
                            case '*': bracketsResult *= currenChar - '0'; break;
                            case '/': bracketsResult /= currenChar - '0'; break;
                            case '%': bracketsResult %= currenChar - '0'; break;
                        }
                    }
                    else
                    {
                        switch (currentOperator)
                        {
                            case '+': result += currenChar - '0'; break;
                            case '-': result -= currenChar - '0'; break;
                            case '*': result *= currenChar - '0'; break;
                            case '/': result /= currenChar - '0'; break;
                            case '%': result %= currenChar - '0'; break;
                        }
                    }
                }
                else if (currenChar == '+' || currenChar == '-' || currenChar == '*' || currenChar == '/' || currenChar == '%')
                {
                    if (inBrackets)
                    {
                        bracketsOperstor = currenChar;
                    }
                    else
                    {
                        currentOperator = currenChar;
                    }
                }
                else if (currenChar == '(')
                {
                    inBrackets = true;
                }
                else if (currenChar == ')')
                {
                    inBrackets = false;

                    switch (currentOperator)
                    {
                        case '+': result += bracketsResult; break;
                        case '-': result -= bracketsResult; break;
                        case '*': result *= bracketsResult; break;
                        case '/': result /= bracketsResult; break;
                        case '%': result %= bracketsResult; break;
                    }

                    bracketsOperstor = '+';
                    bracketsResult = 0;
                }
            }
            Console.WriteLine("{0:F3}", result);
        }
    }
}
