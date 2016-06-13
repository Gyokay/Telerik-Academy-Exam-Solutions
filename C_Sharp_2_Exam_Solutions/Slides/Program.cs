using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slides
{
    class Ball
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }

        public Ball(int width, int hetight, int depth)
        {
            this.Width = width;
            this.Height = hetight;
            this.Depth = depth;
        }
    }

    class Program
    {
        static int cubeWidth;
        static int cubeHeight;
        static int cubeDepth;
        static string[,,] cube;
        static Ball ball;

        static void Main(string[] args)
        {
            
        }

        static void FillArr()
        {

        }
    }
}
