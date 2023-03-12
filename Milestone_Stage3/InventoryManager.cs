// Joshua Turner
// This is my own, original work

namespace InventorySystem
{
    class InventoryManager
    {
        // Private field
        private Inventory[] _inventoryitems;

        // Default constructor, instantiates an array with a size of 0
        public InventoryManager()
        {
            _inventoryitems = new Inventory[0];
        }

        // Properties for field
        public Inventory[] InventoryItems { get { return _inventoryitems; } set { _inventoryitems = value; } }

        // Methods
        public void addItem(Inventory item)
        {
            // Copying the current contents of inventoryItems to a tempInventory array
            Inventory[] tempInventory = new Inventory[InventoryItems.Length + 1];
            for (int i = 0; i < InventoryItems.Length; i++)
            {
                tempInventory[i] = InventoryItems[i];
            }
            tempInventory[tempInventory.Length - 1] = item;
            // Transfering tempInventory contents to the main array
            InventoryItems = new Inventory[tempInventory.Length];
            for (int i = 0; i < tempInventory.Length; i++)
            {
                InventoryItems[i] = tempInventory[i];
            }
        }
        public void removeItem(int productNumber)
        {
            // Finding the index of the intended item for removal using Array.IndexOf
            Inventory[] tempInventory = new Inventory[InventoryItems.Length - 1];
            int index = -1;
            foreach (Inventory item in InventoryItems)
            {
                if (item.ProductNumber == productNumber)
                {
                    index = Array.IndexOf(InventoryItems, item);
                }
            }
            // IndexOf returns -1 if couldn't find a matching index
            if (index != -1)
            {
                for (int i = 0; i < InventoryItems.Length; i++)
                {
                    if (i < index)
                    {
                        tempInventory[i] = InventoryItems[i];
                    }
                    else if (i > index)
                    {
                        tempInventory[i - 1] = InventoryItems[i];
                    }
                }
            }
            InventoryItems = tempInventory;
        }
        public void restockItem(int value, int productNumber)
        {
            // Getting the index of a number the matches product number
            int index = -1;
            foreach (Inventory item in InventoryItems)
            {
                if (item.ProductNumber == productNumber)
                {
                    index = Array.IndexOf(InventoryItems, item);
                }
            }
            // Updating the QuantityOnHand property of the matching index
            if (index != -1)
            {
                InventoryItems[index].QuantityOnHand += value;
            }
        }

        public string[] displayItems()
        {
            // Creates a string array of each inventory item for display purposes
            string[] stringArray = new string[InventoryItems.Length];
            for (int i = 0; i < InventoryItems.Length; i++)
            {
                stringArray[i] = InventoryItems[i].ToString();
            }
            return stringArray;
        }

        public string searchItem(string name)
        {
            // Iterate through InventoryItems array, until a matching property is found
            Inventory searchItem;
            string searchResult = String.Empty;
            // Boolean that'll confirm if a matching item was found
            bool foundResult = false;
            for (int i = 0; i < InventoryItems.Length; i++)
            {
                if (InventoryItems[i].ProductName == name)
                {
                    searchItem = InventoryItems[i];
                    // Calls the ToString() method to turn the object into a displayable string
                    searchResult = searchItem.ToString();
                    // Setting confirmation boolean to true
                    foundResult = true;
                }
            }
            // Checks if a matching value was found
            if (foundResult)
            {
                return searchResult;
            }
            else
            {
                return "No matching item was found, please try again.";
            }
        }

        public string searchItem(int productNumber)
        {
            // Iterate through InventoryItems array, until a matching property is found
            Inventory searchItem;
            string searchResult = String.Empty;
            for (int i = 0; i < InventoryItems.Length; i++)
            {
                if (InventoryItems[i].ProductNumber == productNumber)
                {
                    searchItem = InventoryItems[i];
                    // Calls the ToString() method to turn the object into a displayable string
                    searchResult = searchItem.ToString();
                }
            }
            return searchResult;

        }
    }
}