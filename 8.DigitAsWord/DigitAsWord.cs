using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.DigitAsWord
{
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Write a digit = ");
                int digit = int.Parse(Console.ReadLine());

                switch (digit)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    default:
                        Console.WriteLine("zero");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("not a digit");
            }

        }
    }
}
