using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.Write("Input a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b=");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int temp = b;
                b = a;
                a = temp;
                Console.WriteLine("a=" + a + " b=" + b);
            }
            else
            {
                Console.WriteLine("a<=b");
            }
        }
    }
}
