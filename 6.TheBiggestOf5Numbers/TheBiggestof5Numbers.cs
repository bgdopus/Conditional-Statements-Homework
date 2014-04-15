using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TheBiggestOf5Numbers
{
    class TheBiggestof5Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d=");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e=");
            double e = double.Parse(Console.ReadLine());
            
            double comparison = Math.Max(a, b);
            double comparison2 = Math.Max(c, d);
            double comparison3 = Math.Max(comparison, comparison2);
            double comparison4 = Math.Max(comparison3, e);
            Console.WriteLine("The Biggest is = " + comparison4);
        }
    }
}
