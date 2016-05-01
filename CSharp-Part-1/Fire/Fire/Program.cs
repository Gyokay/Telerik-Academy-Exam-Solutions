using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < width / 2; i++)
            {
                for (int j = 0; j < width / 2 - i - 1; j++)
                {
                    Console.Write('.');
                }

                Console.Write('#');

                for (int j = 0; j < i; j++) //or j < i * 2;
                {
                    Console.Write("..");    //or '.'
                }

                Console.Write('#');

                for (int j = 0; j < width / 2 - i - 1; j++)
                {
                    Console.Write('.');
                }

                Console.WriteLine();
            }

            for (int i = 0; i < width / 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }

                Console.Write('#');

                for (int j = 0; j < width - i - i - 2; j++)
                {
                    Console.Write('.');
                }

                Console.Write('#');

                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }

                Console.WriteLine();
            }

            for (int i = 0; i < width; i++)
            {
                Console.Write('-');
            }

            Console.WriteLine();

            for (int i = 0; i < width / 2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                for (int j = 0; j < width / 2 - i; j++)
                {
                    Console.Write('\\');
                }
                for (int j = 0; j < width / 2 - i; j++)
                {
                    Console.Write('/');
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();
            }
        }
    }
}


/*┈┈╱▏┈┈┈┈┈╱▔▔▔▔╲┈ 
  ┈┈▏▏┈┈┈┈┈▏╲▕▋▕▋▏ 
  ┈┈╲╲┈┈┈┈┈▏┈▏┈▔▔▔▆ 
  ┈┈┈╲▔▔▔▔▔╲╱┈╰┳┳┳╯ 
  ╱╲╱╲▏┈┈┈┈┈┈▕▔╰━╯ 
  ▔╲╲╱╱▔╱▔▔╲╲╲╲┈┈┈ 
  ┈┈╲╱╲╱┈┈┈┈╲╲▂╲▂┈ 
  ┈┈┈┈┈┈┈┈┈┈┈╲╱╲╱┈*/
