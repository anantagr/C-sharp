using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductClasses;

namespace Product_Class_Developement
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendor logitech     = new Vendor("The Logitech Corp.", "800-555-1212", "mice@logitech.com",  Vendor.PreferedContact.Email);
            Vendor bose         = new Vendor("Bose Speaker Ltd.",  "403-829-9944", "speaker@bose.com",   Vendor.PreferedContact.Email);
            Vendor windows      = new Vendor("Windows Laptops Corp.", "233-989-7827", "surface@windows.com", Vendor.PreferedContact.Email);

            Vendor hersheys     = new Vendor("The Hersheys",       "555-777-7612", "enjoy@hersheys.com", Vendor.PreferedContact.Telephone);

            Product mouse       = new Product("Canada mouse", 23456, 12M, 10, logitech);
            Product speaker     = new Product("Soundbar 700", 8976, 34M, 20, bose);
           
            //Console.WriteLine($"Company that sells me mouse is {mouse.SellingCompany.CompanyName}");
            //Console.WriteLine($"Company that sells me speaker is {speaker.SellingCompany.CompanyName}");

            //Creating a new list with name "inventory"
            List<Product> inventory = new List<Product>();

            //Adding products in list

            inventory.Add(new Candy("Twislers", 24233, 0.10M, 1000, hersheys, 100));
            inventory.Add(new Candy("Almond Joy", 123, 0.10M, 2500, hersheys, 125));
            inventory.Add(mouse);
            inventory.Add(speaker);
            inventory.Add(new Computer("ASUS", 456, 299M, 10, logitech, 8, 2.77M));
            inventory.Add(new Computer("Surface", 121, 750M, 8, windows, 12, 3.50M));


            //Displaying each product in Inventory and their quantity
            //foreach (Product p in inventory)
            //{
            //    Console.WriteLine($"{p.Name,-15}   {p.QuantityOnHand}");
            //}



            foreach (Product p in inventory)
            {
                if (p is Computer)
                {
                    Computer c = (Computer)p;
                    Console.WriteLine($"{p.Name,-15}   {p.QuantityOnHand,4}   {p.SellingCompany.CompanyName,7}  and the ram size is {c.RamSize}");
                }
                else
                {
                    Console.WriteLine($"{p.Name,-15}   {p.QuantityOnHand,4}   {p.SellingCompany.CompanyName,7}  ");
                }
                
                p.Sell(5);
            }

            Console.WriteLine("\n Quantity after selling 5 unit \n");


            foreach (Product p in inventory)
            {
                if (p is Computer)
                {
                    Computer c = (Computer)p;
                    Console.WriteLine($"{p.Name,-15}   {p.QuantityOnHand,4}   {p.SellingCompany.CompanyName,7}  and the ram size is {c.RamSize}");
                }
                else
                {
                    Console.WriteLine($"{p.Name,-15}   {p.QuantityOnHand,4}   {p.SellingCompany.CompanyName,7}  ");
                }
            }

            Console.WriteLine("\nQuantity after restocking 10 units \n");

            foreach (Product p in inventory)
            {
                p.Restock(10);
                
                if (p is Computer)
                {
                    Computer c = (Computer)p;
                    Console.WriteLine($"{p.Name,-15}   {p.QuantityOnHand,4}   {p.SellingCompany.CompanyName,7}  and the ram size is {c.RamSize}");
                }
                else
                {
                    Console.WriteLine($"{p.Name,-15}   {p.QuantityOnHand,4}   {p.SellingCompany.CompanyName,7}  ");
                }
            }



            //Product p1 = new Product("ASUS Laptop", 123456, 299.99M, 10);
            //Product p2 = new Product("Chocolate BArs", 37465, 0.10M, 100);
            //Console.WriteLine($"after instanciation {p1.Name} {p1.InternalCost}");
            //Console.WriteLine($"Inventory value of {p1.Name} is {p1.InventoryValue}");

            //p1.Sell(4);
            //p2.Sell(40);
            //p2.Restock(100);
            //Console.WriteLine($"Quantity value of {p1.Name} is {p1.QuantityOnHand}");


            //vendor class testing

            //Vendor logitech = new Vendor("The Logitech Corp.", "800-555-1212", "mice@logitech.com", Vendor.PreferedContact.Email);

            //Console.WriteLine($"Prefered way to contact {logitech.CompanyName} is {logitech.GetPreferedContact()}");
        }
    }
}
