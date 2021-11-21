using System;

namespace SharpenYourSkills.Model
{
    public class Product
    {
        public String name { get; set; }
        public int upc { get; set; }
        public double price { get; set; }

        public Product(String name, int upc, double price) 
        {
            this.name = name;
            this.upc = upc;
            this.price = price + (price * 1 / 5);
        }

        public override string ToString()
        {
            return "Name: " + name + " UPC: "+ upc + " Price: " + price;
        }
    }
}
