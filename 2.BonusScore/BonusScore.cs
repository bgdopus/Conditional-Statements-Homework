using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number=");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    number = number * 10;
                    Console.WriteLine(number);
                    break;
                case 2:
                    number = number * 10;
                    Console.WriteLine(number);
                    break;
                case 3:
                    number = number * 10;
                    Console.WriteLine(number);
                    break;
                case 4:
                    number = number * 100;
                    Console.WriteLine(number);
                    break;
                case 5:
                    number = number * 100;
                    Console.WriteLine(number);
                    break;
                case 6:
                    number = number * 100;
                    Console.WriteLine(number);
                    break;
                case 7:
                    number = number * 1000;
                    Console.WriteLine(number);
                    break;
                case 8:
                    number = number * 1000;
                    Console.WriteLine(number);
                    break;
                case 9:
                    number = number * 1000;
                    Console.WriteLine(number);
                    break;
                default: 
                    Console.WriteLine("Invalid score");
                    break;
            }
        }
    }
}
