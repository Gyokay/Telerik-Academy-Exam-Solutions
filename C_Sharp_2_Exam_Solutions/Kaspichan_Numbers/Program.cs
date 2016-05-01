using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Kaspichan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // POINTS: 100

            ulong decimalNum = ulong.Parse(Console.ReadLine());
            string[] arr = new string[256];

            FillArray(arr);

            List<ulong> convertedNum = ConvertFromDecima(decimalNum, 256);

            string result = "";

            foreach (ulong num in convertedNum)
            {
                result += arr[num];
            }

            Console.WriteLine(result);
        }

        // conver FROM Decimal to any base
        static public List<ulong> ConvertFromDecima(ulong number, ulong numeralBase)
        {
            List<ulong> output = new List<ulong>();
            output.Add(0); //handles --> number = 0

            while (number > 0)
            {
                ulong reminder = number % numeralBase;
                number /= numeralBase;

                output.Insert(0, reminder);
            }

            if (output.Count > 1 && output[output.Count - 1] == 0) //handles --> number = 0
            {
                output.RemoveAt(output.Count - 1);
            }

            return output;
        }

        static public void FillArray(string[] character)
        {
            int index = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                character[index] = i.ToString();
                index++;
            }

            index = 26;
            bool isEnd = false;
            for (char i = 'a'; i <= 'z'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    character[index] = i.ToString() + j;
                    index++;

                    if (index == 256)
                    {
                        isEnd = true;
                        break;
                    }
                }

                if (isEnd) break;
            }

        }
    }
}
