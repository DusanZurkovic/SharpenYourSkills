using SharpenYourSkills.Model;
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

            var product = new Product(name, cpu, price,discount,20);

            Console.WriteLine($"Tax = 20%, discount = {discount}%, tax amount = {round(price * 20 / 100)}, discount amount = {product.discount}, price before = {product.price}, price after = {round(price + (price * 20 / 100) - product.discount) }");

        }

        public static void report()
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

            var product = new Product(name, cpu, price,discount,20);

            var discountValue = discount != 0 ? $"Discount = {product.discount}," : "" ;

            Console.WriteLine($"Cost = {product.price},Tax = {product.price - price},  {discountValue} Total = {price + (price * 20 / 100) - product.discount }");

        }

        public static void combining()
        {
            String name;
            int cpu;
            double price;
            double discount;
            double upcDiscount;
            double tax;
            Console.WriteLine("Insert the name of product: ");
            name = Console.ReadLine();

            Console.WriteLine("Insert the cpu of product: ");
            cpu = int.Parse(Console.ReadLine());


            Console.WriteLine("Insert the price of product: ");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the tax of product: ");
            tax = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the discount of product: ");
            discount = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the upc discount of product: ");
            upcDiscount = double.Parse(Console.ReadLine());

            var finalTax = tax != 0 ? tax : 20;

            var upcDiscountValue = price * upcDiscount / 100;

            var product = new Product(name, cpu, price,discount,finalTax);

            var packing = price * 1 / 100;

            Console.WriteLine($"Cost = {round(price)},Tax = {round(product.price - price)}, Discount ={product.discount + upcDiscountValue},Packaging = {packing}, Transport = 2.2  ,Total = {round(price + packing + 2.2) }");

        }

        public static void selective()
        {
            String name;
            int cpu;
            double price;
            double discount;
            double tax;

            Console.WriteLine("Insert the name of product: ");
            name = Console.ReadLine();

            Console.WriteLine("Insert the cpu of product: ");
            cpu = int.Parse(Console.ReadLine());


            Console.WriteLine("Insert the price of product: ");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the discount of product: ");
            discount = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the tax of product: ");
            tax = double.Parse(Console.ReadLine());

            var taxForPrice = tax != 0 ? tax : 20;

            var product = new Product(name, cpu, price, discount,taxForPrice);

            Console.WriteLine($"Cost = {round(price)},Tax = {round(product.price - price)}, Discount ={product.discount}, Total = {round(price +(product.price - price) - product.discount) }");
        }

        public static void precedence()
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

            var upcDiscountValue = price * 7 / 100;
            var newPrice = price - upcDiscountValue;
            var taxAmount = newPrice * 1 / 5;
            var univerzalDiscount = newPrice * discount / 100;
            var finalPrice = price - upcDiscountValue + taxAmount - univerzalDiscount;

            Console.WriteLine($"Cost = {round(price)},Tax = {round(taxAmount)}, Discount ={round(univerzalDiscount + upcDiscountValue)}, Total = {round(finalPrice)}");

        }

        public static void expenses()
        {
            String name;
            int cpu;
            double price;
            double discount;
            double discountCpu;
            double tax;


            Console.WriteLine("Insert the name of product: ");
            name = Console.ReadLine();

            Console.WriteLine("Insert the cpu of product: ");
            cpu = int.Parse(Console.ReadLine());


            Console.WriteLine("Insert the price of product: ");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the tax of product: ");
            tax = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the discount of product: ");
            discount = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the discount of cpu: ");
            discountCpu = double.Parse(Console.ReadLine());

            var packingCost = price / 100;
            var taxAmount = price * tax / 100;
            var discounts = price * discountCpu / 100 + price * discount / 100;
            var total = price + taxAmount - discounts + packingCost + 2.2;
            Console.WriteLine($"Cost = {round(price)},Tax = {round(taxAmount)}, Discount ={round(discounts)}, Packing = {packingCost},Total = {round(total)}");


        }

        public static void cap()
        {
            String name;
            int cpu;
            double price;
            double discount;
            double discountCpu;
            double tax;
            double cap;


            Console.WriteLine("Insert the name of product: ");
            name = Console.ReadLine();

            Console.WriteLine("Insert the cpu of product: ");
            cpu = int.Parse(Console.ReadLine());


            Console.WriteLine("Insert the price of product: ");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the tax of product: ");
            tax = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the discount of product: ");
            discount = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the discount of cpu: ");
            discountCpu = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the cap: ");
            cap = double.Parse(Console.ReadLine());

            var product = new Product(name, cpu, price, discount, tax);

            var packingCost = price / 100;
            var taxAmount = product.price - price;
            var discountValue = product.discount + price * cpu / 100;
            var total = price + taxAmount - product.discount;
            var capValue = price * cap/100;
            Console.WriteLine($"Cost = {round(price)},Tax = {round(taxAmount)}, Discount ={discountValue}, Packing = {packingCost},Cap ={capValue}, Total = {round(total)}");
        }
        public static void curency()
        {
            String name;
            int cpu;
            double price;
           

            Console.WriteLine("Insert the name of product: ");
            name = Console.ReadLine();

            Console.WriteLine("Insert the cpu of product: ");
            cpu = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert the price of product: ");
            price = double.Parse(Console.ReadLine());

            var taxAmount = price * 20 / 100;

            Console.WriteLine($"Cost = {round(price)} USD,Tax = {round(taxAmount)} USD,  Total = {round(price + taxAmount)} USD");

        }

        public static void precisions()
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

         
            var taxAmount = roundOnFourDigits(price * tax / 100);
            var universalDiscounts = roundOnFourDigits(price * 15 / 100);
            var upcDiscount = roundOnFourDigits((price - universalDiscounts) * 7 / 100);
            var totalDiscount = universalDiscounts + upcDiscount;
            var transportCost = price * 3 / 100;
            var total = price + taxAmount - totalDiscount + transportCost;
            Console.WriteLine($"Cost = {round(price)} USD,Tax = {round(taxAmount) } USD, Discount ={round(totalDiscount)} USD, Transparent = {transportCost} USD,Total = {round(total)} USD");

        }

        private static double round(double value)
        {
            return Math.Round(value, 2);
        }

        private static double roundOnFourDigits(double value)
        {
            return Math.Round(value, 4);
        }
    }
}
