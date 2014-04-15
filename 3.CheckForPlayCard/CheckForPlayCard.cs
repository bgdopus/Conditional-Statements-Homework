using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CheckForPlayCard
{
    class CheckForPlayCard
    {
        static void Main(string[] args)
        {
            Console.Write("show a card=");
            string card = Console.ReadLine();
            switch (card)
            {
                case "2":
                    
                    Console.WriteLine(card);
                    break;
                case "3":
                    
                    Console.WriteLine("yes");
                    break;
                case "4":

                    Console.WriteLine("yes");
                    break;
                case "5":

                    Console.WriteLine("yes");
                    break;
                case "6":

                    Console.WriteLine("yes");
                    break;
                case "7":

                    Console.WriteLine("yes");
                    break;
                case "8":

                    Console.WriteLine("yes");
                    break;
                case "9":

                    Console.WriteLine("yes");
                    break;
                case "10":

                    Console.WriteLine("yes");
                    break;
                case "j":

                    Console.WriteLine("yes");
                    break;
                case "q":

                    Console.WriteLine("yes");
                    break;
                case "k":

                    Console.WriteLine("yes");
                    break;
                case "a":

                    Console.WriteLine("yes");
                    break;
                default:
                    Console.WriteLine("no");
                    break;
            }
        }
    }
}
