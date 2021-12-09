using System;

namespace SharpenYourSkills.Model
{
    public class Product
    {
        public String name { get; set; }
        public int upc { get; set; }
        public double price { get; set; }

        public double discount { get; set; }

        public double tax { get; set; }

        public Product(String name, int upc, double price, double discount, double tax) 
        {
            this.name = name;
            this.upc = upc;
            this.price = Math.Round(price + (price * tax / 100),2);
            this.discount =  Math.Round(price * discount / 100 , 2);
        }

        public Product(String name, int upc, double price)
        {
            this.name = name;
            this.upc = upc;
            this.price = Math.Round(price + (price * 1 / 5), 2);
        }

        public override string ToString()
        {
            return "Name: " + name + " UPC: "+ upc + " Price: " + price;
        }
    }
}
