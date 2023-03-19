// Joshua Turner
// This is my own, original work

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
            // Removing the item, if a matching item was found
            if (index != -1)
            {
                InventoryItems.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("An item with a matching product number was not found");
            }
        }

        public void removeItem(string productName)
        {
            // Finding the index of the desired removed item
            int index = InventoryItems.FindIndex(a => a.ProductName == productName);
            // Removing the item, if a matching item was found
            if (index != -1)
            {
                InventoryItems.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("An item with a matching product number was not found");
            }
        }

        public void restockItem(int value, int productNumber)
        {
            // Finding the index of the item
            int index = InventoryItems.FindIndex(a =>a.ProductNumber == productNumber);
            // Incrementing the QuantityOnHand property by the input value
            if (index != -1)
            {
                InventoryItems[index].QuantityOnHand += value;
            }
            else
            {
                MessageBox.Show("An item with a matching product number was not found");
            }
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

        public List<string> searchItem(string name)
        {
            // List to hold all vlaues that match the search term
            List<string> searchResults = new List<string>();
            
            for (int i = 0;i < InventoryItems.Count;i++)
            {
                // Looks for an inventory Item with a property matching the parameter
                if (InventoryItems[i].ProductName == name)
                {
                    searchResults.Add(InventoryItems[i].ToString());
                }
            }
            if (searchResults.Count == 0) 
            {
                searchResults.Add("No matching item was found, please revise and try again");
            }
            return searchResults;
        }

        public List<string> searchItem(int productNumber)
        {
            // List to hold all values that match the search term
            List<string> searchResults = new List<string>();

            for (int i = 0; i < InventoryItems.Count; i++)
            {
                // Looks for an inventory Item with a property matching the parameter
                if (InventoryItems[i].ProductNumber == productNumber)
                {
                    searchResults.Add(InventoryItems[i].ToString());
                }
            }
            if (searchResults.Count == 0)
            {
                searchResults.Add("No matching item was found, please revise and try again");
            }
            return searchResults;

        }

        public void readFromFile(StreamReader streamReader)
        {
            // Reads each line from the input StreamRead variable
            string objectString = streamReader.ReadLine();
            while (objectString != null)
            {
                // Splits the string into an array by commas, and parses the Inventory values from that
                string[] splitString = objectString.Split(",");
                int quantHand = int.Parse(splitString[0]);
                int quantOrd = int.Parse(splitString[1]);
                int prodNum = int.Parse(splitString[2]);
                string prodName = splitString[3];
                double purchPrice = double.Parse(splitString[4]);
                double sellPrice = double.Parse(splitString[5]);
                // Creates the Inventory object and adds it to the InventoryItems list
                InventoryItems.Add(new Inventory(quantHand, quantOrd, prodNum, prodName, purchPrice, sellPrice));
                objectString = streamReader.ReadLine();
            }
        } 

        public void writeToFile(StreamWriter streamWriter)
        {
            // Iterates through each Inventory object in the main List
            foreach(Inventory item in InventoryItems)
            {
                // Breaks each object into it's properties and seperates them by a comma
                streamWriter.WriteLine(item.QuantityOnHand + "," + item.QuantityOrdered + ","
                    + item.ProductNumber + "," + item.ProductName + "," + item.PurchasePrice + ","
                    + item.SellPrice);
            }
        }
    }
}