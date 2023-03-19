namespace Milestone_Project
{
    public partial class View_Menu : Form
    {
        public View_Menu()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            //Clearing the listBox
            inventoryListBox.Items.Clear();
            // An string array that hold all inventory items
            string[] stringArray = Program.InventoryManager.displayItems();
            // Adding each item to the listBox
            foreach (string str in stringArray)
            {
                inventoryListBox.Items.Add(str);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show(this);
        }

        private void reorderProdName_Click(object sender, EventArgs e)
        {
            //  Sorting Product Name alphabetically, using the CompareTo method
            Program.InventoryManager.InventoryItems.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));
        }

        private void reorderProdNum_Click(object sender, EventArgs e)
        {
            // Sorting Product Number numerically, using the CompareTo method
            Program.InventoryManager.InventoryItems.Sort((x, y) => x.ProductNumber.CompareTo(y.ProductNumber));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
