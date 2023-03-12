// Joshua Turner, CST-150
// This is my own, original work

namespace InventorySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Creates an InventoryManager object, that is modifiable by each control
        private InventoryManager InventoryManager { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            InventoryManager = new InventoryManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Getting data for inventory item
            int quantHand = int.Parse(quantityOnHandText.Text);
            int quantOrd = int.Parse(quantityOrderedText.Text);
            int productNum = int.Parse(productNumberText.Text);
            string prodName = productNameText.Text;
            double purchPrice = double.Parse(purchasePriceText.Text);
            double sellPrice = double.Parse(sellPriceText.Text);

            // Adding the new invetory item to the Inventory Manager array
            InventoryManager.addItem(new Inventory(quantHand, quantOrd, productNum, prodName, purchPrice, sellPrice));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Calling the removeItem method from the InventoryManager class
            int productNumber = int.Parse(removeProductNumberText.Text);
            InventoryManager.removeItem(productNumber);
        }

        private void Restock_Click(object sender, EventArgs e)
        {
            // Calling the restockItem method from InventoryManager class
            int prodNum = int.Parse(restockProdNumText.Text);
            int amount = int.Parse(restockAmountText.Text);
            InventoryManager.restockItem(amount, prodNum);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            string[] stringArray = InventoryManager.displayItems();
            foreach (string stringItem in stringArray)
            {
                inventoryListBox.Items.Add(stringItem);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // NEEDS WORK
            searchItemsListBox.Items.Clear();
            string searchResult;
            if (prodNameRadio.Checked || prodNumberRadio.Checked)
            {
                if (prodNameRadio.Checked)
                {
                    searchResult = InventoryManager.searchItem(searchTerm.Text);
                }
                else
                {
                    searchResult = InventoryManager.searchItem(int.Parse(searchTerm.Text));
                }
                searchItemsListBox.Items.Add(searchResult.ToString());
            }
            else
            {
                MessageBox.Show("Please select one of the search options.");
            }
        }
    }
}