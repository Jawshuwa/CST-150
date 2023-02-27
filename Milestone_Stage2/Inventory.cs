// Joshua Turner, CST-150, this is my own work
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Inventory
    {
        // Private fields for inventory items
        private int _quantityonhand;
        private int _quantityordered;
        private int _productnnumber;
        private string _productname;
        private double _purchaseprice;
        private double _sellprice;

        // Constructor, with default values of 0 or empty
        public Inventory()
        {
            _quantityonhand = 0;
            _quantityordered = 0;
            _productnnumber = 0;
            _productname = string.Empty;
            _purchaseprice = 0;
            _sellprice = 0;
        }

        // Properties for the fields
        public int QuantityOnHand { get { return _quantityonhand; } set { _quantityonhand = value; } }
        public int QuantityOrdered { get { return _quantityordered; } set { _quantityordered = value; } }
        public int ProductNumber { get { return _productnnumber; } set { _productnnumber = value; } }
        public string ProductName { get { return _productname; } set { _productname = value; } }
        public double PurchasePrice { get { return _purchaseprice; } set { _purchaseprice = value; } }
        public double SellPrice { get { return _sellprice; } set { _sellprice = value; } }

        // Methods
        public double CalculateRevenue()
        {
            // Returns base revenue from an item sale
            return SellPrice - PurchasePrice;
        }

        public double CalculateRevenue(int saleNumber)
        {
            // Returns base revenue for many item sales of the object
            return saleNumber * (SellPrice - PurchasePrice);
        }

        public double ApplyDiscount(double percent)
        {
            // Takes the parameter and converts it to a decimal to calculate a discounted sell price
            double dicount = percent / 100;
            return SellPrice - (SellPrice * dicount);
        }
    }
}

