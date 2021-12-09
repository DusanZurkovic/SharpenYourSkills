using SharpenYourSkills.Method;
using SharpenYourSkills.Model;
using System;

namespace SharpenYourSkills
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Tax");
            Console.WriteLine("2) Discount");
            Console.WriteLine("3) Report");
            Console.WriteLine("4) Selective");
            Console.WriteLine("5) Precedence");
            Console.WriteLine("6) Expenses");
            Console.WriteLine("7) Combining");
            Console.WriteLine("8) Cap");
            Console.WriteLine("9) Currency");
            Console.WriteLine("10) Precision");
            Console.WriteLine("11) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Methods.tax();
                    return true;
                case "2":
                    Methods.discount();
                    return true;
                case "3":
                    Methods.report();
                    return true;
                case "4":
                    Methods.selective();
                    return true;
                case "5":
                    Methods.precedence();
                    return true;
                case "6":
                    Methods.expenses();
                    return true;
                case "7":
                    Methods.combining();
                    return true;
                case "8":
                    Methods.cap();
                    return true;
                case "9":
                    Methods.curency();
                    return true;
                case "10":
                    Methods.precisions();
                    return true;
                case "11":
                    return false;
                default:
                    Console.WriteLine("Bad option, try again");
                    return true;
            }
        }
    }
}
