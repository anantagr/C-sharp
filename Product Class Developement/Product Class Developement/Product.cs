using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClasses
{
    // right click on Product Calss Development, and
    // Add --> New item --> Class

    // By default, it's private class
    // put public in front of class Product to make it public class
    // RECOMMENDATION: Explicitly declare the class level: public or private in front of class  
    public class Product
    {
        //define my public properties for this object
        // instance variables called name, having public property
        // classes called product, class is template for building object
        // convention: for public variables, declare it starting with capital letter.
        public string Name                  //name of the product
        {
            set
            {
                if ((value == null) || (value.Trim().Length == 0))
                {
                    throw new ArgumentException("Empty or blank name");
                }

                name = value.Trim();
            }

            get
            {
                return name;
            }
        }

        public int SKU                      //the stock keeping unit for this product
        {
            get
            {
                return sku;
            }
        }

        public decimal InternalCost         //the internal cost of the product
        {
            set
            {
                // is code to the setting of the shadow property
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Negative Internal Cost");
                }

                internalCost = value;
            }

            get
            {
                // is code to the getting of the shadow property
                return internalCost;
            }
        }

        public int QuantityOnHand           //the current amount of this product
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Negative Quantity on Hand");
                }

                quantityOnHand = value;
            }

            get
            {
                return quantityOnHand;
            }
        }

        public decimal InventoryValue       //calculated Inventory value
        {
            get
            {
                return QuantityOnHand * InternalCost; 
            }
        }

        public Vendor   SellingCompany;

        private decimal         internalCost;
        private string          name;
        private int             quantityOnHand;
        private  int            sku;


        // constructors are methods that always have the same name as the class
        // constructors are unique, only for creating objects and instances of the class
        // constructor returns a reference to this object,
        // so the datatype is known, no need to specify the datatype: datatype of Product

        //my constructors

        public Product(string productName, int itemSKU, decimal cost, int quantity, string vendor)
        // Pass four args: name, sku, internalcost, quantityonhand  ------> later on ADD one more arg ---> string vendor
        {
            Name            = productName;
            sku             = itemSKU;
            InternalCost    = cost;
            QuantityOnHand  = quantity;

            SellingCompany = new Vendor(vendor);
        }

        public Product(string productName, int itemSKU, decimal cost, int quantity, Vendor vendor)
        // Pass four args: name, sku, internalcost, quantityonhand  ------> later on ADD one more arg ---> Vendor vendor
        {
            Name            = productName;
            sku             = itemSKU;
            InternalCost    = cost;
            QuantityOnHand  = quantity;

            SellingCompany  = vendor;
        }

        public Product(string productName, int sku)
        // another constructor --------->    pass two args: name, sku. later on ADD one more arg ---> Selling company as null
        {
            Name            = productName;
            this.sku        = sku;
            InternalCost    = 0;
            QuantityOnHand  = 0;

            SellingCompany  = null;
        }


        public virtual int Sell(int quantityToSell)
        // Public Sell Method
        {
            if (quantityToSell <=0)
            {
                throw new ArithmeticException("Cannot sell non-positive value");
            }

            if(QuantityOnHand - quantityToSell < 0)
            {
                throw new ArgumentOutOfRangeException("Dont have enough inventory");
            }
            
            QuantityOnHand -= quantityToSell;
            return QuantityOnHand;
        }

        public virtual int Restock(int quantityAdded)
        // Public Restock Method
        {
            if (quantityAdded <= 0)
            {
                throw new ArithmeticException("Cannot restock non-positive value");
            }

            QuantityOnHand += quantityAdded;
            return QuantityOnHand;
        }
        
    }
}
