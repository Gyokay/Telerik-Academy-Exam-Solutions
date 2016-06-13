using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Is_Better_Than_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(FindPalindrome(a, b));
        }

        static int FindPalindrome(int a, int b)
        {
            int result = 0;

            for (int i = a; i <= b; i++)
            {
                bool isLuckyNum = true;
                bool isPalindrome = false;

                int current = i;
                string currStr = i.ToString();

                foreach (var item in currStr)
                {
                    if (item != 5 || item != 3)
                    {
                        isLuckyNum = false;
                        break;
                    }
                }

                string reverseStr = ReverseString(currStr);

                if (currStr == reverseStr)
                {
                    isPalindrome = true;
                }

                if (isLuckyNum && isPalindrome)
                {
                    result++;
                }
            }

            return result;
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
