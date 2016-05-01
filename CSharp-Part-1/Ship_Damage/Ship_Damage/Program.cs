using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Damage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sx1 = int.Parse(Console.ReadLine());
            int Sy1 = int.Parse(Console.ReadLine());
            int Sx2 = int.Parse(Console.ReadLine());
            int Sy2 = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int Cx1 = int.Parse(Console.ReadLine());
            int Cy1 = int.Parse(Console.ReadLine());
            int Cx2 = int.Parse(Console.ReadLine());
            int Cy2 = int.Parse(Console.ReadLine());
            int Cx3 = int.Parse(Console.ReadLine());
            int Cy3 = int.Parse(Console.ReadLine());

            int damage = 0;
            int C1 = H + (H - Cy1);
            int C2 = H + (H - Cy2);
            int C3 = H + (H - Cy3);

            if (Sy2 > Sy1)
            {
                int temp = Sy1;

                Sy1 = Sy2;
                Sy2 = temp;
            }

            if (Sx2 < Sx1)
            {
                int temp = Sx1;

                Sx1 = Sx2;
                Sx2 = temp;
            }

            // 100% damage

            if (Sy1 > C1 && Sy2 < C1 && Sx1 < Cx1 && Sx2 > Cx1)
            {
                damage += 100;
            }

            if (Sy1 > C2 && Sy2 < C2 && Sx1 < Cx2 && Sx2 > Cx2)
            {
                damage += 100;
            }

            if (Sy1 > C3 && Sy2 < C3 && Sx1 < Cx3 && Sx2 > Cx3)
            {
                damage += 100;
            }

            // 50% damage

            if ((Cx1 == Sx1 || Cx1 == Sx1) && (C1 < Sy1 && C1 > Sy2))
            {
                damage += 50;
            }

            if ((Cx2 == Sx1 || Cx2 == Sx1) && (C2 < Sy1 && C2 > Sy2))
            {
                damage += 50;
            }

            if ((Cx3 == Sx1 || Cx3 == Sx1) && (C3 < Sy1 && C3 > Sy2))
            {
                damage += 50;
            }

            //

            if ((C1 == Sy1 || C1 == Sy2) && (Cx1 < Sx2 && Cx1 > Sx1))
            {
                damage += 50;
            }

            if ((C2 == Sy1 || C2 == Sy2) && (Cx2 < Sx2 && Cx2 > Sx1))
            {
                damage += 50;
            }

            if ((C3 == Sy1 || C3 == Sy2) && (Cx3 < Sx2 && Cx3 > Sx1))
            {
                damage += 50;
            }

            // points

            if (Cx1 == Sx1 && (C1 == Sy1 || C1 == Sy2))
            {
                damage += 25;
            }

            if (Cx2 == Sx1 && (C2 == Sy1 || C2 == Sy2))
            {
                damage += 25;
            }

            if (Cx3 == Sx1 && (C3 == Sy1 || C3 == Sy2))
            {
                damage += 25;
            }

            //

            if (Cx1 == Sx2 && (C1 == Sy1 || C1 == Sy2))
            {
                damage += 25;
            }

            if (Cx2 == Sx2 && (C2 == Sy1 || C2 == Sy2))
            {
                damage += 25;
            }

            if (Cx3 == Sx2 && (C3 == Sy1 || C3 == Sy2))
            {
                damage += 25;
            }




            Console.WriteLine("{0}{1}", damage, '%');

        }
    }
}
