using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateSumOfSequence
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter positive intiger number n and intiger x: ");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1.0;
        int fact = 1;
        int devider = 1;
        for (int i = 1; i <= n; i++)
        {
            devider *= x;
            fact *= i;
            sum += ((double)fact / (double)devider);
        }
        Console.WriteLine("The sum = {0:F5}", sum);
    }
}
