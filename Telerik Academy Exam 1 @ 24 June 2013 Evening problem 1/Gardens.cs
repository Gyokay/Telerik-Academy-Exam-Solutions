//  100/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_Academy_Exam_1___24_June_2013_Evening_problem_1
{
    class Gardens
    {
        static void Main(string[] args)
        {
            int tomatoSeeds = int.Parse(Console.ReadLine());
            float tomatoTotaCost = tomatoSeeds * 0.5F;
            int tomatoArea = int.Parse(Console.ReadLine());

            int cucumberSeeds = int.Parse(Console.ReadLine());
            float cucumberTotaCost = cucumberSeeds * 0.4F;
            int cucumberArea = int.Parse(Console.ReadLine());

            int potatoSeeds = int.Parse(Console.ReadLine());
            float potatoTotaCost = potatoSeeds * 0.25F;
            int potatoArea = int.Parse(Console.ReadLine());

            int carrotSeeds = int.Parse(Console.ReadLine());
            float carrotTotaCost = carrotSeeds * 0.6F;
            int carrotArea = int.Parse(Console.ReadLine());

            int cabbageSeeds = int.Parse(Console.ReadLine());
            float cabbageTotaCost = cabbageSeeds * 0.3F;
            int cabbageArea = int.Parse(Console.ReadLine());

            int beansSeeds = int.Parse(Console.ReadLine());
            float beansTotaCost = beansSeeds * 0.4F;

            int beansArea = 250 - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);

            float totalSeedCost = tomatoTotaCost + cucumberTotaCost + potatoTotaCost + carrotTotaCost + cabbageTotaCost + beansTotaCost;

            Console.WriteLine("Total costs: {0:0.00}", totalSeedCost);

            if (beansArea > 0)
            {
                Console.WriteLine("Beans area: {0}", beansArea);
            }
            else if (beansArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
