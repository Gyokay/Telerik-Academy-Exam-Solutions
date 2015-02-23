using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Printing
{
    class Program
    {
        static void Main(string[] args)
        {
            float n = float.Parse(Console.ReadLine());//n - students in academy
            float s = float.Parse(Console.ReadLine());//s - The number of paper sheets that should be printed for each student 
            float p = float.Parse(Console.ReadLine());//p - The price of one realm

            float paperNeeded = n*s;
            float totalRealms = paperNeeded / 500;
            float savedMoney = totalRealms * p;
            Console.WriteLine("{0:F2}", savedMoney);


        }

    }
}
