using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaspichania_boats
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (n * 2) + 1;
            long height = 6 + ((n - 3) / 2) * 3;
            decimal sail = Math.Round(decimal.Divide(2M, 3M) * height);


            for (int i = 0; i < height; i++)
            {
                if (i == 0)
                {
                    StringBuilder line = new StringBuilder();
                    string dots = new string('.', n);
                    line.Append(dots);
                    line.Append('*');
                    line.Append(dots);

                    Console.WriteLine(line);
                }
                else if (i == 1)
                {
                    StringBuilder line = new StringBuilder();
                    string dots = new string('.', n - 1);
                    line.Append(dots);
                    line.Append("***");
                    line.Append(dots);

                    Console.WriteLine(line);
                }
                else if (i > 1 && i < sail - 1)
                {
                    StringBuilder line = new StringBuilder();
                    string dots = new string('.', n - i);
                    string sideDots = new string('.', i - 1);
                    line.Append(dots);
                    line.Append('*');
                    line.Append(sideDots);
                    line.Append('*');
                    line.Append(sideDots);
                    line.Append('*');
                    line.Append(dots);

                    Console.WriteLine(line);
                }
                else if (i == sail - 1)
                {
                    string line = new string('*', width);
                    Console.WriteLine(line);
                }
                else if (i > sail - 1 && i < height - 1)
                {
                    StringBuilder line = new StringBuilder();
                    string dots = new string('.', i - n);
                    string sideDots = new string('.', (n - 1) - (i - n));
                    line.Append(dots);
                    line.Append('*');
                    line.Append(sideDots);
                    line.Append('*');
                    line.Append(sideDots);
                    line.Append('*');
                    line.Append(dots);

                    Console.WriteLine(line);
                }
                else if (i == height - 1)
                {
                    StringBuilder line = new StringBuilder();
                    string dots = new string('.', width - i);
                    string stars = new string('*', n);
                    line.Append(dots);
                    line.Append(stars);
                    line.Append(dots);

                    Console.WriteLine(line);
                }

            }
        }
    }
}
