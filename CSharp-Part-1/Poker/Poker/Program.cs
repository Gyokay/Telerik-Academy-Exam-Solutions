using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {

            byte c0 = 0; // A
            byte c1 = 0; byte c2 = 0; byte c3 = 0; byte c4 = 0; byte c5 = 0; byte c6 = 0; byte c7 = 0; byte c8 = 0; byte c9 = 0; ; byte c10 = 0; // 1 - 10  
            byte c11 = 0; //J
            byte c12 = 0; //Q
            byte c13 = 0; //K

            string[] arr = new string[5];

            for (int i = 0; i < 5; i++)
            {
                arr[i] = Console.ReadLine();

                switch (arr[i])
                {
                    case "A": c0++; break;
                    case "1": c1++; break;
                    case "2": c2++; break;
                    case "3": c3++; break;
                    case "4": c4++; break;
                    case "5": c5++; break;
                    case "6": c6++; break;
                    case "7": c7++; break;
                    case "8": c8++; break;
                    case "9": c9++; break;
                    case "10": c10++; break;
                    case "J": c11++; break;
                    case "Q": c12++; break;
                    case "K": c13++; break;

                }
            }

            bool fiveOfAKind = c0 == 5 || c1 == 5 || c2 == 5 || c3 == 5 || c4 == 5 || c5 == 5 || c6 == 5 || c7 == 5 || c8 == 5 || c9 == 5 || c10 == 5 || c11 == 5 || c12 == 5 || c13 == 5;
            bool fourOfAKind = c0 == 4 || c1 == 4 || c2 == 4 || c3 == 4 || c4 == 4 || c5 == 4 || c6 == 4 || c7 == 4 || c8 == 4 || c9 == 4 || c10 == 4 || c11 == 4 || c12 == 4 || c13 == 4;
            bool threeOfAKind = c0 == 3 || c1 == 3 || c2 == 3 || c3 == 3 || c4 == 3 || c5 == 3 || c6 == 3 || c7 == 3 || c8 == 3 || c9 == 3 || c10 == 3 || c11 == 3 || c12 == 3 || c13 == 3;
            bool twoOfAKind = c0 == 2 || c1 == 2 || c2 == 2 || c3 == 2 || c4 == 2 || c5 == 2 || c6 == 2 || c7 == 2 || c8 == 2 || c9 == 2 || c10 == 2 || c11 == 2 || c12 == 2 || c13 == 2;

            byte twoOfAKindCount = 0;

            if (c0 == 2) twoOfAKindCount++;
            if (c1 == 2) twoOfAKindCount++;
            if (c2 == 2) twoOfAKindCount++;
            if (c3 == 2) twoOfAKindCount++;
            if (c4 == 2) twoOfAKindCount++;
            if (c5 == 2) twoOfAKindCount++;
            if (c6 == 2) twoOfAKindCount++;
            if (c7 == 2) twoOfAKindCount++;
            if (c9 == 2) twoOfAKindCount++;
            if (c10 == 2) twoOfAKindCount++;
            if (c11 == 2) twoOfAKindCount++;
            if (c12 == 2) twoOfAKindCount++;
            if (c13 == 2) twoOfAKindCount++;

            bool straigth = false;

            if (c0 == 1 && c1 == 1 && c2 == 1 && c3 == 1 && c4 == 1) straigth = true;
            if (c1 == 1 && c2 == 1 && c3 == 1 && c4 == 1 && c5 == 1) straigth = true;
            if (c2 == 1 && c3 == 1 && c4 == 1 && c5 == 1 && c6 == 1) straigth = true;
            if (c3 == 1 && c4 == 1 && c5 == 1 && c6 == 1 && c7 == 1) straigth = true;
            if (c4 == 1 && c5 == 1 && c6 == 1 && c7 == 1 && c8 == 1) straigth = true;
            if (c5 == 1 && c6 == 1 && c7 == 1 && c8 == 1 && c9 == 1) straigth = true;
            if (c6 == 1 && c7 == 1 && c8 == 1 && c9 == 1 && c10 == 1) straigth = true;
            if (c7 == 1 && c8 == 1 && c9 == 1 && c10 == 1 && c11 == 1) straigth = true;
            if (c8 == 1 && c9 == 1 && c10 == 1 && c11 == 1 && c12 == 1) straigth = true;
            if (c9 == 1 && c10 == 1 && c11 == 1 && c12 == 1 && c13 == 1) straigth = true;
            if (c10 == 1 && c11 == 1 && c12 == 1 && c13 == 1 && c0 == 1) straigth = true;




            if (fiveOfAKind) Console.WriteLine("Impossible");
            else if (fourOfAKind) Console.WriteLine("Four of a Kind");
            else if (threeOfAKind && twoOfAKind) Console.WriteLine("Full House");
            else if (straigth) Console.WriteLine("Straight");
            else if (threeOfAKind) Console.WriteLine("Three of a Kind");
            else if (twoOfAKindCount == 2) Console.WriteLine("Two Pairs");
            else if (twoOfAKind) Console.WriteLine("One Pair");
            else Console.WriteLine("Nothing");
        }
    }
}
