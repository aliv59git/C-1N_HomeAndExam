using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ZeroSubset
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter five intiger numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        bool success = false;

        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, b);
            success = true;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
            success = true;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
            success = true;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
            success = true;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, c);
            success = true;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, d);
            success = true;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, e);
            success = true;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
            success = true;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
            success = true;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
            success = true;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            success = true;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            success = true;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            success = true;
        }
        if (d + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", d, b, c);
            success = true;
        }
        if (e + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", e, b, c);
            success = true;
        }
        if (a + d + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, c);
            success = true;
        }
        if (a + e + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, e, c);
            success = true;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            success = true;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            success = true;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            success = true;
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            success = true;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            success = true;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            success = true;
        }
        if (a + e + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, e, c, d);
            success = true;
        }
        if (e + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", e, b, c, d);
            success = true;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            success = true;
        }
        if(success == false)
        {
            Console.WriteLine("No zero subset");
        }
    }
}
