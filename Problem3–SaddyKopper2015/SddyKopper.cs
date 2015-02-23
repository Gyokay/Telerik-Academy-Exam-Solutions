//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_SaddyKopper2015
{
    class SddyKopper
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int noLast = input / 10;
            int sum = 0;
            for (int i = 0; i < noLast.ToString().Length; i += 2)
            {
                
                int numb = i;
                if (numb != 0)
                {
                    sum += numb % 10;
                    numb = numb / 10;
                }
            }
            Console.WriteLine(sum);
        } 

    }       
}
