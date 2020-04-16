using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClasses
{
    public class Computer : Product
    // absorb everything(properties and behaviours) in Product Class to Computer Class
    {
        public int      RamSize;
        public decimal  CPUSpeed;

        // Constructor
        // Not just initializing RamSize and CPUSpeed, we should intialize all the variables in Product.cs
        // have to build product object first
        // : base() - paramters to 
        // the variable names in Computer constructor should match the ones in base().
        // The order of parameters in base should match with the order in Product constructor, the name doesn't matter.
        public Computer(string  productName, 
                       int      itemSKU, 
                       decimal  cost, 
                       int      quantity, 
                       Vendor   vendor,
                       int      ram,
                       decimal  Speed) : base(productName, itemSKU, cost, quantity, vendor)
        
        {
            RamSize = ram;
            CPUSpeed = Speed;
            //Name = productName;           --------> Comes from Product class
            //sku = itemSKU;                --------> Comes from Product class
            //InternalCost = cost;          --------> Comes from Product class
            //QuantityOnHand = quantity;    --------> Comes from Product class

            //SellingCompany = new Vendor(vendor);  --------> Comes from Product class
        }
    }
}
