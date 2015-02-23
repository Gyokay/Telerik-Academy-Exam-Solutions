using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MollyAndMolly
{
    class MollyAndMolly
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
                        
            int b = int.Parse(Console.ReadLine());
                         
            int c = int.Parse(Console.ReadLine());
            int r = 0;
            int result = 0;
            int reminder = 0;
            
            if (b == 2)
             {
                r = a % c;
             }
             else if (b == 4)
             {
                r = a + c;
             }
             else if (b == 8)
             {
                r = a * c;
             }

             if (r % 4 == 0)
             {
                 result = r / 4;
                 Console.WriteLine(result);
             }

             else
             {
                 reminder = r % 4;
                 Console.WriteLine(reminder);
             }

             Console.WriteLine(r);
        }
    }
}
