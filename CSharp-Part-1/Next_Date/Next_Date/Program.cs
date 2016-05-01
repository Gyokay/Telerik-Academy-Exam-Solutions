using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day).AddDays(1);
            Console.WriteLine(date.Day + "." + date.Month + "." + date.Year);
        }
    }
}
