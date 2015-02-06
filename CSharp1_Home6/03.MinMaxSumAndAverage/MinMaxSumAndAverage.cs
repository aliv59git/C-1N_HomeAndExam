using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MinMaxSumAndAverage
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter positive intiger number n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter {0} intiger numbers: ", n);
        int[] arr = new int[n];
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (min > arr[i])
            {
                min = arr[i];
            }
            if (max < arr[i])
            {
                max = arr[i];
            }
            sum += arr[i];
        }
        float average = (float)sum / n;
        Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \naverage = {3:F2}", min, max, sum, average);
    }
}
