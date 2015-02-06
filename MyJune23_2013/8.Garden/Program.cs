using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int tomatoS = int.Parse(Console.ReadLine());
            int tomatoA = int.Parse(Console.ReadLine());
            int cucumbS = int.Parse(Console.ReadLine());
            int cucumbA = int.Parse(Console.ReadLine());
            int potatoS = int.Parse(Console.ReadLine());
            int potatoA = int.Parse(Console.ReadLine());
            int carrotS = int.Parse(Console.ReadLine());
            int carrotA = int.Parse(Console.ReadLine());
            int cabS = int.Parse(Console.ReadLine());
            int cabA = int.Parse(Console.ReadLine());
            int beanS = int.Parse(Console.ReadLine());
            decimal totalCost = 0;
            int totalArea5 = 0;
            totalCost = (decimal)(tomatoS * 0.5 + cucumbS * 0.4 + potatoS * 0.25 + carrotS * 0.6 + cabS * 0.3 + beanS * 0.4);
            Console.WriteLine("Total costs: {0:F2}", totalCost);

            totalArea5 = tomatoA + cucumbA + potatoA + carrotA + cabA;
            if (totalArea5 > 250)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (totalArea5 == 250)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Beans area: {0}", 250 - totalArea5);
            }



        }
    }
}

