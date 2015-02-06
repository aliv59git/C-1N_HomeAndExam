using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter n intiger numbers, separated by space");
        string[] str = Console.ReadLine().Split(' ');
        int[] arr = new int[str.Length];
        int odd_product = 1;
        int even_product = 1;
        for (int i = 0; i < str.Length; i++)
        {
            arr[i] = int.Parse(str[i]);
            if (i % 2 == 0)
            {
                odd_product *= arr[i];
            }
            else
            {
                even_product *= arr[i];
            }
        }
        if (odd_product == even_product)
        {
            Console.WriteLine("Yes, product = {0}", odd_product);
        }
        else
        {
            Console.WriteLine("No, \nodd_product = {0}, \neven_product = {1}", odd_product, even_product);
        }
    }
}
