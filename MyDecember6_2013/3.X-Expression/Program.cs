using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.X_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str.Trim();
            int operand = str[1]+0;
            int operand1 = 0;
            decimal result = str[0] - 48;
            decimal result1 = 0;
            decimal result2 = 0;
            int count = 0;
            for (int i = 2; i < str.Length; i++)
            {
                if ((str[0] + 0) == 45)
                {
                    result = -(str[1]-48);
                    operand = str[2]+0;
                    i++;
                }


                if ((str[i] + 0 >= 49) && (str[i] <= 57))
                {
                    result1 = str[i] - 48;
                    switch(operand)
                    {
                        case 43: result += result1; break;
                        case 45: result-= result1; break;
                        case 42: result *=result1; break;
                        case 47: result /=result1; break;
                    }

                }
                if (str[i] + 0 == 43)
                {
                    operand = 43;
                }
                if (str[i] + 0 == 45)
                {
                    operand = 45;
                }
                if (str[i] + 0 == 42)
                {
                    operand = 42;
                }
                if (str[i] + 0 == 47)
                {
                    operand = 47;
                }

                if (str[i] + 0 == 61)
                {
                    break;
                }

                if (str[i] + 0 == 40)
                {
                    operand1 = 0;
                    count = 1;
                    i++;
                    result2 = str[i]-48;
                    while ((str[i] + 0) != 41)
                    {
                        count++;
                        if ((str[i] + 0 >= 49) && (str[i] <= 57))
                        {
                            result1 = str[i] - 48;
                            switch (operand1)
                            {
                                case 43: result2 += result1; break;
                                case 45: result2 -= result1; break;
                                case 42: result2 *= result1; break;
                                case 47: result2 /= result1; break;
                            }

                        }
                        if (str[i] + 0 == 43)
                        {
                            operand1 = 43;
                        }
                        if (str[i] + 0 == 45)
                        {
                            operand1 = 45;
                        }
                        if (str[i] + 0 == 42)
                        {
                            operand1 = 42;
                        }
                        if (str[i] + 0 == 47)
                        {
                            operand1 = 47;
                        }
                    i++;
                    }
                    count++;
                    result1 = result2;
                    switch (operand)
                    {
                        case 43: result += result1; break;
                        case 45: result -= result1; break;
                        case 42: result *= result1; break;
                        case 47: result /= result1; break;
                    }
                }

            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
