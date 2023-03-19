// Joshua Turner, CST-150
// This is my own original work

namespace Milestone_Project
{
    class Inventory
    {
        // Private fields for inventory items
        private int _quantityonhand;
        private int _quantityordered;
        private int _productnumber;
        private string _productname;
        private double _purchaseprice;
        private double _sellprice;

        // Constructor, with default values of 0 or empty
        public Inventory()
        {
            _quantityonhand = 0;
            _quantityordered = 0;
            _productnumber = 0;
            _productname = string.Empty;
            _purchaseprice = 0;
            _sellprice = 0;
        }

        // Overloaded method to fill all fields for the inventory object
        public Inventory(int quantHand, int quantOrd, int productNum, string prodName, double purchPrice, double sellPrice)
        {
            _quantityonhand = quantHand;
            _quantityordered = quantOrd;
            _productnumber = productNum;
            _productname = prodName;
            _purchaseprice = purchPrice;
            _sellprice = sellPrice;
        }

        // Properties for the fields
        public int QuantityOnHand { get { return _quantityonhand; } set { _quantityonhand = value; } }
        public int QuantityOrdered { get { return _quantityordered; } set { _quantityordered = value; } }
        public int ProductNumber { get { return _productnumber; } set { _productnumber = value; } }
        public string ProductName { get { return _productname; } set { _productname = value; } }
        public double PurchasePrice { get { return _purchaseprice; } set { _purchaseprice = value; } }
        public double SellPrice { get { return _sellprice; } set { _sellprice = value; } }

        // Methods
        public string ToString()
        {
            // Turns the Inventory object into a string for display purposes
            string stringItem;
            stringItem = ("Product number: " + this.ProductNumber.ToString()
                    + " | Product name: " + this.ProductName + " | Quantity on hand: "
                    + this.QuantityOnHand.ToString() + " | Quantity ordered: "
                    + this.QuantityOrdered.ToString() + " | Purchase price: " + this.PurchasePrice.ToString()
                    + "| Sell price: " + this.SellPrice.ToString());
            return stringItem;
        }
    }
}

