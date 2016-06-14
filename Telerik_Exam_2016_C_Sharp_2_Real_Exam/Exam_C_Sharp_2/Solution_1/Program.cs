using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 from strange system to dec
            //2 make the operation and find the result
            //3 conavert the result to strange system
            //4 output the result

            string firstNum = Console.ReadLine();
            string oper = Console.ReadLine();
            string secondNum = Console.ReadLine();

            List<BigInteger> f = Convert(firstNum);
            List<BigInteger> s = Convert(secondNum);

            BigInteger ff = BigInteger.Parse(string.Join("", f));
            BigInteger ss = BigInteger.Parse(string.Join("", s));

            BigInteger result = Calculate(ff, ss, oper);

            Console.WriteLine(ToStrange(result));
        }
        static BigInteger Calculate(BigInteger ff, BigInteger ss, string oper)
        {
            if (oper == "-")
            {
                return ff - ss;
            }
            else
            {
                return ff + ss;
            }
        }

        static List<BigInteger> Convert(string num)
        {
            List<BigInteger> number = new List<BigInteger>();
            int indexStart = 0;
            int length = 1;

            while (indexStart < num.Length)
            {
                int currentNum = StringToNumber(num.Substring(indexStart, length));

                if (currentNum != -1)
                {
                    number.Add(currentNum);
                    indexStart += length;
                    length = 1;
                }
                else
                {
                    length++;
                }
            }

            return number;
        }


        static int StringToNumber(string s)
        {
            if (s == "cad") return 0;
            else if (s == "xoz") return 1;
            else if (s == "nop") return 2;
            else if (s == "cyk") return 3;
            else if (s == "min") return 4;
            else if (s == "mar") return 5;
            else if (s == "kon") return 6;
            else if (s == "iva") return 7;
            else if (s == "ogi") return 8;
            else if (s == "yan") return 9;
            else return -1;
        }

        static string ToStrange(BigInteger num)
        {
            var result = new StringBuilder();

            string[] strangeNums = new string[] {"cad", "xoz", "nop", "cyk", "min", "mar",
                                                 "kon", "iva", "ogi", "yan" };


            string numString = num.ToString();

            for (int i = 0; i < numString.Length; i++)
            {
                result.Append(strangeNums[int.Parse(numString[i].ToString())]);
            }

            return result.ToString();
        }
    }
}
