using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            double product = a * b * c;
            if (product == 0)
            {
                Console.WriteLine("The product is 0");
            }
            else
            {
                if (product > 0)
                {
                    Console.WriteLine("The product is +");
                }
                else
                {
                    Console.WriteLine("The product is -");
                }
            }
        }
    }
}
