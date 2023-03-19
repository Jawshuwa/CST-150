// Joshua Turner
// This is my own, original work

using System.Xml.Linq;

namespace Milestone_Project
{
    class InventoryManager
    {
        // Private field
        private List<Inventory> _inventoryitems;

        // Default constructor, instantiates an array with a size of 0
        public InventoryManager()
        {
            _inventoryitems = new List<Inventory>();
        }

        // Properties for field
        public List<Inventory> InventoryItems { get { return _inventoryitems; } set { _inventoryitems = value; } }

        // Methods
        public void addItem(Inventory item)
        {
            // Adds the input item to the Inventory list
            InventoryItems.Add(item);
        }
        public void removeItem(int productNumber)
        {
            // Finding the index of the desired removed item
            int index = InventoryItems.FindIndex(a => a.ProductNumber == productNumber);
            // Removing the item
            InventoryItems.RemoveAt(index);
        }
        public void restockItem(int value, int productNumber)
        {
            // Finding the index of the item
            int index = InventoryItems.FindIndex(a =>a.ProductNumber == productNumber);
            // Incrementing the QuantityOnHand property by the input value
            InventoryItems[index].QuantityOnHand += value;
        }

        public string[] displayItems()
        {
            // Creates a string array of each inventory item for display purposes
            string[] stringArray = new string[InventoryItems.Count];
            for (int i = 0; i < InventoryItems.Count; i++)
            {
                stringArray[i] = InventoryItems[i].ToString();
            }
            return stringArray;
        }

        public string searchItem(string name)
        {
            // Temp variables needed for the search process
            string searchResult = string.Empty;
            // Finding index using the input search term
            int index = InventoryItems.FindIndex(a => a.ProductName == name);
            if (index != -1)
            {
                return searchResult = InventoryItems[index].ToString();
            }
            else
            {
                return "No matching item was found, please try again.";
            }

        }

        public string searchItem(int productNumber)
        {
            // Temp variables needed for the search process
            string searchResult = string.Empty;
            // Finding index using the input search term
            int index = InventoryItems.FindIndex(a => a.ProductNumber == productNumber);
            if (index != -1)
            {
                return searchResult = InventoryItems[index].ToString();
            }
            else
            {
                return "No matching item was found, please try again.";
            }

        }


    }
}