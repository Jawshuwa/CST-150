using Milestone_v1._5;

namespace Milestone_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Creating the InventoryManager object
            Program.InventoryManager = new InventoryManager();

            if (File.Exists("inventorySystem.txt"))
            {
                // Creating a StreamReader variable
                StreamReader inputFile;
                inputFile = File.OpenText("inventorySystem.txt");
                // Calling the readFromFile method to populate the inventoryItems array
                Program.InventoryManager.readFromFile(inputFile);
                inputFile.Close();
            }

            // Using the displayItems() method, add them to the listBox
            string[] inventory = Program.InventoryManager.displayItems();
            foreach (string item in inventory)
            {
                inventoryListBox.Items.Add(item);
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Creating a StreamWriter variable
            StreamWriter outputFile;
            outputFile = File.CreateText("inventorySystem.txt");
            // Calling the writeToFile method to write the current inventory objects
            Program.InventoryManager.writeToFile(outputFile);

            outputFile.Close();
        }

        private void editMenu_RefreshInventory(object sender, EventArgs e)
        {
            // Event that will update the inventory by performing a click on the button
            viewInventoryButton.PerformClick();
        }

        private void viewInventoryButton_Click(object sender, EventArgs e)
        {
            inventoryListBox.Items.Clear();
            // Using the displayItems() method, add them to the listBox
            string[] inventory = Program.InventoryManager.displayItems();
            foreach (string item in inventory)
            {
                inventoryListBox.Items.Add(item);
            }
        }

        private void editMenuButton_Click(object sender, EventArgs e)
        {
            EditMenu editMenu = new EditMenu();
            // Adding the RefreshInventory event to the editMenu form
            editMenu.RefreshInventory += new EventHandler(editMenu_RefreshInventory);
            editMenu.Show(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show(this);
        }

        private void reorderProdName_Click(object sender, EventArgs e)
        {
            inventoryListBox.Items.Clear();
            // Creating a new List to display, to maintain the order of the original list
            List<Inventory> prodNumOrder = Program.InventoryManager.InventoryItems;
            // Sorting list alphabetically by ProductName property of Inventory objects
            prodNumOrder.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));
            // Adds each item of the new list to the inventoryListBox
            foreach (Inventory item in prodNumOrder)
            {
                inventoryListBox.Items.Add(item.ToString());
            }
        }

        private void reorderProdNum_Click(object sender, EventArgs e)
        {
            inventoryListBox.Items.Clear();
            // Creating a new List to display, to maintain the order of the original list
            List<Inventory> prodNameOrder = Program.InventoryManager.InventoryItems;
            // Sorting list alphabetically by ProductNumber property of Inventory objects
            prodNameOrder.Sort((x, y) => x.ProductNumber.CompareTo(y.ProductNumber));
            // Adds each item of the new list to the inventoryListBox
            foreach (Inventory item in prodNameOrder)
            {
                inventoryListBox.Items.Add(item.ToString());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
