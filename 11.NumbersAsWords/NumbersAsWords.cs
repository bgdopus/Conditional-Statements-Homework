using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersAsWords
{
    class NumbersAsWords
    {
        public static void Digits(int number)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine(" Zero ");
                    break;
                case 1:
                    Console.Write(" One ");
                    break;
                case 2:
                    Console.Write(" Two ");
                    break;
                case 3:
                    Console.Write(" Three ");
                    break;
                case 4:
                    Console.Write(" Four ");
                    break;
                case 5:
                    Console.Write(" Five ");
                    break;
                case 6:
                    Console.Write(" Six ");
                    break;
                case 7:
                    Console.Write(" Seven ");
                    break;
                case 8:
                    Console.Write(" Eight ");
                    break;
                case 9:
                    Console.Write(" Nine ");
                    break;
                default:
                    break;
            }
        }
        public static void SpecialCases(int number)
        {
            switch (number)
            {
                case 10:
                    Console.Write(" Ten ");
                    break;
                case 11:
                    Console.Write(" Eleven ");
                    break;
                case 12:
                    Console.Write(" Twelve ");
                    break;
                case 13:
                    Console.Write(" Thirteen ");
                    break;
                case 14:
                    Console.Write(" Fourteen ");
                    break;
                case 15:
                    Console.Write(" Fifteen ");
                    break;
                case 16:
                    Console.Write(" Sixteen ");
                    break;
                case 17:
                    Console.Write(" Seventeen ");
                    break;
                case 18:
                    Console.Write(" Eighteen ");
                    break;
                case 19:
                    Console.Write(" Nineteen ");
                    break;
                default:
                    break;
            }
        }
        public static void Tens(int number)
        {
            switch (number)
            {
                case 2:
                    Console.Write(" Twenty ");
                    break;
                case 3:
                    Console.Write(" Thirty ");
                    break;
                case 4:
                    Console.Write(" Fourty ");
                    break;
                case 5:
                    Console.Write(" Fifty ");
                    break;
                case 6:
                    Console.Write(" Sixty ");
                    break;
                case 7:
                    Console.Write(" Seventy ");
                    break;
                case 8:
                    Console.Write(" Eighty ");
                    break;
                case 9:
                    Console.Write(" Ninety ");
                    break;
                default:
                    break;
            }
        }
        public static void Hundreds(int number)
        {
            switch (number)
            {
                case 1:
                    Console.Write(" One Hundred ");
                    break;
                case 2:
                    Console.Write(" Two Hunderd ");
                    break;
                case 3:
                    Console.Write(" Three Hundred ");
                    break;
                case 4:
                    Console.Write(" Four Hundred ");
                    break;
                case 5:
                    Console.Write(" Five Hundred ");
                    break;
                case 6:
                    Console.Write(" Six Hundred ");
                    break;
                case 7:
                    Console.Write(" Seven Hundred ");
                    break;
                case 8:
                    Console.Write(" Eight Hundred ");
                    break;
                case 9:
                    Console.Write(" Nine Hundred ");
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number < 999 -->");
            int number = int.Parse(Console.ReadLine());
            
                   int lastTwo = number % 100;
                   int lastOne = lastTwo % 10;
                   int tens = (lastTwo - lastOne) / 10;
                   int hundreds = number - lastTwo;
                   int firstDigit = hundreds / 100;

                   if (number < 1000)
                   {
                       if (number < 100)
                       {
                           if (number < 20)
                           {
                               if (number < 10)
                               {
                                   Digits(lastOne);
                               }
                               else
                               {
                                   SpecialCases(lastTwo);
                               }
                           }
                           else
                           {
                               if (lastOne == 0)
                               {
                                   Tens(tens);

                               }
                               else
                               {
                                   Tens(tens);
                                   Digits(lastOne);
                               }
                           }

                       }
                       else
                       {
                           if (tens==1)
                           {
                               if (lastOne == 0)
                               {
                                   Hundreds(firstDigit);
                                   Tens(tens);
                               }
                               else
                               {
                                   Hundreds(firstDigit);
                                   SpecialCases(lastTwo);
                               }
                           }
                           else
                           {
                               if (lastTwo == 0)
                               {
                                   Hundreds(firstDigit);
                               }
                               else
                               {
                                   Hundreds(firstDigit);
                                   Tens(tens);
                                   Digits(lastOne);
                               }

                           }
                       }

                   }
                   else
                   {
                       Console.WriteLine("The Numbre is bigger than 999");
                   }
                   Console.WriteLine(" ");

                  

            }
            
            }
     }
  