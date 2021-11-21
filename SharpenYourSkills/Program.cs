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
            Console.WriteLine("4) Exit");
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
                    Console.WriteLine("Tax2");
                    return true;
                case "4":
                    return false;
                default:
                    Console.WriteLine("Bad option, try again");
                    return true;
            }
        }
    }
}
