using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumb = int.Parse(Console.ReadLine());
            int numb = secretNumb;
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[] secrNumbers = new int[4];
            int[] guesNumbers = new int[4];
            for (int i = 0; i < 4; i++)
            {
                secrNumbers[3-i] = numb % 10;
                numb /= 10;
            }
            bool findNumbers = false;

            for (int i = 1111; i < 9999; i++)
            {
                int temp = i;
                int[] tempSecr = new int[4];
                for (int x = 0; x < 4; x++)
                {
                    tempSecr[x] = secrNumbers[x];
                }
                
                for (int j = 0; j < 4; j++)
                {
                    guesNumbers[3 - j] = temp % 10;
                    temp /= 10;
                }
                int bulls = 0;
                int cows = 0;
                if (guesNumbers[0]==0 || guesNumbers[1]==0 ||guesNumbers[2]==0 || guesNumbers[3]==0)
                {
                    continue;
                }


                for (int t = 0; t < 4; t++)
                {
                    if (tempSecr[t] == guesNumbers[t])
                    {
                        bulls++;
                        tempSecr[t] = -1;
                        guesNumbers[t] = -2;
                    }
                }
                for (int u = 0; u < 4; u++)
                {
                    for (int ui = 0; ui < u; ui++)
                    {
                        if (tempSecr[u] == guesNumbers[ui])
                        {
                            cows++;
                            tempSecr[u] = -3;
                            guesNumbers[ui] = -4;
                        }
                    }
                    for (int ue = 3; ue > u; ue--)
                    {
                        if (tempSecr[u] == guesNumbers[ue])
                        {
                            cows++;
                            tempSecr[u] = -5;
                            guesNumbers[ue] = -6;
                        } 
                    }
                }





                if ((bulls == b) && (cows == c))
                {
                    findNumbers = true;
                    Console.Write(i + " ");
                }
                



            }
            for (int k = 0; k < 4; k++)
            {
                guesNumbers[k] = 0;
            }

            if (!findNumbers)
            {
                Console.WriteLine("No");
            }

            Console.WriteLine();
        }
    }
}
