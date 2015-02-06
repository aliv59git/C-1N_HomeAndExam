using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SequenceOfBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSequenceOnes = 0;
            int bestSequenceZeroes = 0;
            string str = String.Empty;
            for (int i = 0; i < n; i++)
            {
                string strTemp = Console.ReadLine();
                UInt32 numb = UInt32.Parse(strTemp);
                str+= Convert.ToString(numb, 2).PadLeft(30, '0');
            }
            Console.WriteLine(str);
            for (int i = 1; i < str.Length; i++)
            {
                int currentBit = str[0] - 48;
                if (currentBit == 0)
                {
                    bool isTheSame = true;
                    int currZer = 1;
                    while (isTheSame)
                    {
                        if (str[i] - 48 == currentBit)
                        {
                            currZer++;
                            currentBit = str[i];
                            i++;
                            if (i == str.Length)
                            {
                                break;
                            }
                        }
                        else
                        {
                            currentBit = str[i] - 48;
                            isTheSame = false;
                            i++;
                            if (i == str.Length)
                            {
                                break;
                            }
                            if (currZer > bestSequenceZeroes)
                            {
                                bestSequenceZeroes = currZer;
                            }
                        }
                    }
                }
                if (currentBit == 1)
                {
                    bool isTheSame = true;
                    int currOnes = 1;
                    while (isTheSame)
                    {
                        if (i == str.Length)
                        {
                            break;
                        }
                        if (str[i] - 48 == currentBit)
                        {
                            currOnes++;
                            currentBit = str[i] - 48;
                            i++;
                            if (i == str.Length)
                            {
                                break;
                            }
                        }
                        else
                        {
                            currentBit = str[i] - 48;
                            isTheSame = false;
                            i++;
                            if (i == str.Length)
                            {
                                break;
                            }
                            if (currOnes > bestSequenceOnes)
                            {
                                bestSequenceOnes = currOnes;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(bestSequenceOnes);
            Console.WriteLine(bestSequenceZeroes);
        }
    }
}
