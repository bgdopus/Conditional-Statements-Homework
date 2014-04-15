using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine(a + " " + b + " " + c);
                    }
                    else
                    {
                        Console.WriteLine(a + " " + c + " " + b);
                    }
                }
                else
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        Console.WriteLine(b + " " + a + " " + c);
                    }
                    else
                    {
                        Console.WriteLine(b + " " + c + " " + a);
                    }
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
        }
    }
}
