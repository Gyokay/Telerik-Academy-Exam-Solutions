using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_Next_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            if (year >= 2000 && year <= 2013)
            {
                if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
                {
                    if (day < 31)
                    {
                        Console.WriteLine("{0}.{1}.{2}", ++day, month, year);
                    }
                    else if (day == 31 && month < 12)
                    {
                        Console.WriteLine("{0}.{1}.{2}", 1, ++month, year);
                    }
                    else if (day == 31 && month == 12)
                    {
                        Console.WriteLine("{0}.{1}.{2}", 1, 1, ++year);
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }

                    if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
                    {
                        if (day < 30)
                        {
                            Console.WriteLine("{0}.{1}.{2}", ++day, month, year);
                        }
                        else if (day == 30)
                        {
                            Console.WriteLine("{0}.{1}.{2}", 1, ++month, year);
                        }

                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                    }

                    else if (month == 2 && (year == 2000 || year == 2004 || year == 2008 || year == 2012))
                    {
                        if (day < 29)
                        {
                            Console.WriteLine("{0}.{1}.{2}", ++day, month, year);
                        }
                        else if (day == 29)
                        {
                            Console.WriteLine("{0}.{1}.{2}", 1, ++month, year);
                        }
                    }
                    else if (month == 2)
                    {
                        if (day < 28)
                        {
                            Console.WriteLine("{0}.{1}.{2}", ++day, month, year);
                        }
                        else if (day == 28)
                        {
                           Console.WriteLine("{0}.{1}.{2}", 1, ++month, year); 
                        }
                    }


                }

            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

    }

}