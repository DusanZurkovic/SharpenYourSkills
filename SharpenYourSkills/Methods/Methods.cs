﻿using SharpenYourSkills.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenYourSkills.Method
{
    class Methods
    {
        public static void tax()
        {
            String name;
            int cpu;
            double price;
            double tax;
            Console.WriteLine("Insert the name of product: ");
            name = Console.ReadLine();

            Console.WriteLine("Insert the cpu of product: ");
            cpu = int.Parse(Console.ReadLine());


            Console.WriteLine("Insert the price of product: ");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the tax of product: ");
            tax = double.Parse(Console.ReadLine());

            var product = new Product(name, cpu, price);
            Console.WriteLine($"Product price reported as {price} before tax and {product.price} after 20 tax");
            Console.WriteLine($"Product price reported as {price} before tax and {price + (price * tax / 100)} after {tax} tax");
        }

        public static void discount()
        {
            String name;
            int cpu;
            double price;
            double discount;

            Console.WriteLine("Insert the name of product: ");
            name = Console.ReadLine();

            Console.WriteLine("Insert the cpu of product: ");
            cpu = int.Parse(Console.ReadLine());


            Console.WriteLine("Insert the price of product: ");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the discount of product: ");
            discount = double.Parse(Console.ReadLine());

            var product = new Product(name, cpu, price);

            Console.WriteLine($"Tax = 20%, discount = {discount}%, tax amount = {price * 20 / 100}, discount amount = {price * discount / 100}, price before = {product.price}, price after = {price + (price * 20 / 100) - (price * discount / 100) }");

        }
    }
}
