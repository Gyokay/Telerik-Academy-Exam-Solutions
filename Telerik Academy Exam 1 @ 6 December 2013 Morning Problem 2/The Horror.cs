using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int sum = 0;
            int counter = 0;
            int eavenCounter = 0;

            foreach (char symbol in input)
            {
                if (counter % 2 == 0)
                {
                    if (Char.IsNumber(symbol))
                    {
                        sum += int.Parse(symbol.ToString());
                        eavenCounter++;
                    }
                }

                counter++;
            }
            Console.WriteLine("{0} {1}", eavenCounter, sum);
        }
    }
