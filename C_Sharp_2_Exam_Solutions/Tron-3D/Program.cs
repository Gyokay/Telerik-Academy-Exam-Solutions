using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron_3D
{
    class Program
    {
        static int oldX, oldY, oldZ;
        static string redMoves, blueMoves;
        static int X, Y;
        static bool[,] used;
        static int currentRedX;
        static int currentRedY;
        static int currentBlueX;
        static int currentBlueY;

        static void Main(string[] args)
        {
            ReadInput();

            X = oldX;
            Y = oldY * 2 + oldZ * 2;

            used = new bool[X + 1, Y];

            currentRedX = oldX / 2;
            currentRedY = oldY / 2;
            currentBlueX = oldX / 2;
            currentBlueY = oldY + oldZ + (oldY / 2);

            
        }

        static void ReadInput()
        {
            string xyzAsString = Console.ReadLine();
            string[] xyzStringPart = xyzAsString.Split(' ');
            oldX = int.Parse(xyzStringPart[0]);
            oldY = int.Parse(xyzStringPart[1]);
            oldZ = int.Parse(xyzStringPart[2]);

            redMoves = Console.ReadLine();
            blueMoves = Console.ReadLine();
        }
    }
}
