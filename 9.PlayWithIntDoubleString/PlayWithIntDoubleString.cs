using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type ");
            Console.WriteLine("1--> Int");
            Console.WriteLine("2--> Double");
            Console.WriteLine("3--> String");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Please enter Int= ");
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(++intNumber);
                    break;
                case 2:
                    Console.Write("Please enter Double= ");
                    double doubleNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine(++doubleNumber);
                    break;
                case 3:
                    Console.Write("Please enter Double= ");
                    string str = Console.ReadLine();
                    str = str + "*";
                    Console.WriteLine(str);
                    break;
                default:
                    Console.WriteLine("Not listed");
                    break;
            }
        }
    }
}
