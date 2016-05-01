using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Page
{
    class Program
    {
        static void Main(string[] args)
        {
            const string commandEnd = "paypal";
            const string commandBuy = "buy";
            const string commandWhatIs = "what is";

            int row0 = Convert.ToInt32(Console.ReadLine(), 2);
            int row1 = Convert.ToInt32(Console.ReadLine(), 2);
            int row2 = Convert.ToInt32(Console.ReadLine(), 2);
            int row3 = Convert.ToInt32(Console.ReadLine(), 2);
            int row4 = Convert.ToInt32(Console.ReadLine(), 2);
            int row5 = Convert.ToInt32(Console.ReadLine(), 2);
            int row6 = Convert.ToInt32(Console.ReadLine(), 2);
            int row7 = Convert.ToInt32(Console.ReadLine(), 2);
            int row8 = Convert.ToInt32(Console.ReadLine(), 2);
            int row9 = Convert.ToInt32(Console.ReadLine(), 2);
            int row10 = Convert.ToInt32(Console.ReadLine(), 2);
            int row11 = Convert.ToInt32(Console.ReadLine(), 2);
            int row12 = Convert.ToInt32(Console.ReadLine(), 2);
            int row13 = Convert.ToInt32(Console.ReadLine(), 2);
            int row14 = Convert.ToInt32(Console.ReadLine(), 2);
            int row15 = Convert.ToInt32(Console.ReadLine(), 2);


            while (true)
            {
                string command = Console.ReadLine();

                if (command == commandEnd)
                {
                    break;
                }

                int row = int.Parse(Console.ReadLine());
                int col = 15 - int.Parse(Console.ReadLine());

                int upperRow;
                int middleRow;
                int lowerRow;

                switch (row)
                {
                    case 0: upperRow = 0; middleRow = row0; lowerRow = row1; break;
                    case 1: upperRow = row0; middleRow = row1; lowerRow = row2; break;
                    case 2: upperRow = row1; middleRow = row2; lowerRow = row3; break;
                    case 3: upperRow = row2; middleRow = row3; lowerRow = row4; break;
                    case 4: upperRow = row3; middleRow = row4; lowerRow = row5; break;
                    case 5: upperRow = row4; middleRow = row5; lowerRow = row6; break;
                    case 6: upperRow = row5; middleRow = row6; lowerRow = row7; break;
                    case 7: upperRow = row6; middleRow = row7; lowerRow = row8; break;
                    case 8: upperRow = row7; middleRow = row8; lowerRow = row9; break;
                    case 9: upperRow = row8; middleRow = row9; lowerRow = row10; break;
                    case 10: upperRow = row9; middleRow = row10; lowerRow = row11; break;
                    case 11: upperRow = row10; middleRow = row11; lowerRow = row12; break;
                    case 12: upperRow = row11; middleRow = row12; lowerRow = row13; break;
                    case 13: upperRow = row12; middleRow = row13; lowerRow = row14; break;
                    case 14: upperRow = row13; middleRow = row14; lowerRow = row15; break;
                    case 15: upperRow = row14; middleRow = row15; lowerRow = 0; break;
                }

                int cookieCenter = 1 << col;

                if (command == commandWhatIs)
                {

                }
                else if (command == commandBuy)
                {

                }
            }
        }
    }
}
