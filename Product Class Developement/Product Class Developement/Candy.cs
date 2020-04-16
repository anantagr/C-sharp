using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClasses
{
    public class Candy : Product
    {
        public int GramsOfSugar;
        public Candy    (string productName,
                        int itemSKU,
                        decimal cost,
                        int quantity,
                        Vendor vendor,
                        int grams) : base(productName, itemSKU, cost, quantity, vendor)
        {
            GramsOfSugar = grams;
        }


        //Using Candy's Sell method with overriding original Sell method in Product class
        public override int Sell(int quantityToSell) // Use this Sell method over the Sell method in Product Class
        {
            if (quantityToSell < 4)
            {
                throw new ArgumentException("must sell more than 10 at a time.");
            }

            // invoke base class sell method
            return base.Sell(quantityToSell);

            // Sell: Product(Base) Class --> (override) Sell: Candy(Sub) Class --> (virtual) Sell: Product(Base) Class 
        }


        //Using Candy's Restock method with overriding original Restock method in Product class
        public override int Restock(int quantityToRestock) // Use this Sell method over the Sell method in Product Class
        {
            if (quantityToRestock < 8)
            {
                throw new ArgumentException("must restock more than 8 at a time.");
            }

            // invoke base class sell method
            return base.Restock(quantityToRestock);
        }

    }
}
