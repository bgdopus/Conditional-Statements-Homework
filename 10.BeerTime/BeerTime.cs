using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time(hh:mm tt)=");
            string time = Console.ReadLine();
            string[] words = time.Split(' ');
            string[] hourString = words[0].Split(':');
            int hour = int.Parse(hourString[0]);
            int minutes = int.Parse(hourString[1]);

            switch (hour)
            {
                case 1:
                    Console.WriteLine("Beer time");
                    break;
                case 2:
                    Console.WriteLine("Beer time");
                    break;
                case 3:
                    switch (words[1])
                    {
                        case "pm":
                            Console.WriteLine("Beer time");
                            break;
                        case "am":
                            Console.WriteLine("non-beer time");
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    break;
                case 4:
                    switch (words[1])
                    {
                        case "pm":
                            Console.WriteLine("Beer time");
                            break;
                        case "am":
                            Console.WriteLine("non-beer time");
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    break;
                case 5:
                    switch (words[1])
                    {
                        case "pm":
                            Console.WriteLine("Beer time");
                            break;
                        case "am":
                            Console.WriteLine("non-beer time");
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    break;
                case 6:
                    switch (words[1])
                    {
                        case "pm":
                            Console.WriteLine("Beer time");
                            break;
                        case "am":
                            Console.WriteLine("non-beer time");
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    break;
                case 7:
                    switch (words[1])
                    {
                        case "pm":
                            Console.WriteLine("Beer time");
                            break;
                        case "am":
                            Console.WriteLine("non-beer time");
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    break;
                case 8:
                    switch (words[1])
                    {
                        case "pm":
                            Console.WriteLine("Beer time");
                            break;
                        case "am":
                            Console.WriteLine("non-beer time");
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    break;
                case 9:
                    switch (words[1])
                    {
                        case "pm":
                            Console.WriteLine("Beer time");
                            break;
                        case "am":
                            Console.WriteLine("non-beer time");
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    break;
                case 10:
                    switch (words[1])
                    {
                        case "pm":
                            Console.WriteLine("Beer time");
                            break;
                        case "am":
                            Console.WriteLine("non-beer time");
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    break;
                case 11:
                    switch (words[1])
                    {
                        case "pm":
                            Console.WriteLine("Beer time");
                            break;
                        case "am":
                            Console.WriteLine("non-beer time");
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    break;
                case 12:
                    switch (words[1])
                    {
                        case "pm":
                            Console.WriteLine("non-beer time");
                            break;
                        case "am":
                            Console.WriteLine("Beer time");
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
            

        }
    }
}
