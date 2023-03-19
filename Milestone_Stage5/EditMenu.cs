namespace Milestone_Project
{
    public partial class EditMenu : Form
    {
        public EditMenu()
        {
            InitializeComponent();
        }


        public event EventHandler RefreshInventory;


        private void addButton_Click(object sender, EventArgs e)
        {
            // Creating an array of all the textBoxes relevant to the addButton
            var textBoxCollection = new[] { addQuantHandBox, addQuantOrdBox, addProdNumBox, addProdNameBox,
            addPurchPriceBox, addPurchPriceBox, addSellPriceBox};

            // Returns true if any of the textBoxes in array is empty
            bool atLeastOneEmpty = textBoxCollection.Any(t => string.IsNullOrEmpty(t.Text));

            // Checks if bool is false before entering statement
            if (!atLeastOneEmpty)
            {
                // Getting the needed information from textBoxes
                int quantHand = int.Parse(addQuantHandBox.Text);
                int quantOrd = int.Parse(addQuantOrdBox.Text);
                int prodNumber = int.Parse(addProdNumBox.Text);
                string prodName = addProdNameBox.Text;
                double purchPrice = double.Parse(addPurchPriceBox.Text);
                double sellPrice = double.Parse(addSellPriceBox.Text);

                // Calling the addItem() method with paramaters
                Program.InventoryManager.addItem(new Inventory(quantHand, quantOrd, prodNumber, prodName, purchPrice, sellPrice));
                
                // Clearing textBoxes
                foreach (TextBox box in textBoxCollection)
                {
                    box.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please fill the required text boxes before clicking the button");
            }

            // Calling an event to refresh the inventory on MainMenu form
            EventHandler handler = this.RefreshInventory;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Checks if they filled the required form
            if (!string.IsNullOrEmpty(removeTermBox.Text))
            {
                if (productNameButton.Checked || productNumberButton.Checked)
                {
                    // Checks which radio button was selected
                    if (productNameButton.Checked)
                    {
                        Program.InventoryManager.removeItem(removeTermBox.Text);
                    }
                    else
                    {
                        Program.InventoryManager.removeItem(int.Parse(removeTermBox.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Please select one of the options");
                }
            }
            else
            {
                MessageBox.Show("Please fill the text box before clicking the button");
            }

            // Calling an event to refresh the inventory on MainMenu form
            EventHandler handler = this.RefreshInventory;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // Creating an array of all the items revelant to the editButton
            var textBoxCollection = new[] { editQuantHandBox, editProdNameBox, editQuantOrdBox,
            editPurchPrice, editSellPriceBox, editProductNumberBox};

            // Checks if the entered the required field
            if (!string.IsNullOrEmpty(editProductNumberBox.Text))
            {
                // Finding the index of an inventory item with a matching product number
                int prodNumber = int.Parse(editProductNumberBox.Text);
                int index = Program.InventoryManager.InventoryItems.FindIndex(a => a.ProductNumber == prodNumber);

                if (index != -1)
                {
                    // Updates the found Inventory item, only if the respective fields are filled out
                    if (!string.IsNullOrEmpty(editProdNameBox.Text)) { Program.InventoryManager.InventoryItems[index].ProductName = editProdNameBox.Text; }
                    if (!string.IsNullOrEmpty(editQuantHandBox.Text)) { Program.InventoryManager.InventoryItems[index].QuantityOnHand = int.Parse(editQuantHandBox.Text); }
                    if (!string.IsNullOrEmpty(editQuantOrdBox.Text)) { Program.InventoryManager.InventoryItems[index].QuantityOrdered = int.Parse(editQuantOrdBox.Text); }
                    if (!string.IsNullOrEmpty(editPurchPrice.Text)) { Program.InventoryManager.InventoryItems[index].PurchasePrice = double.Parse(editPurchPrice.Text); }
                    if (!string.IsNullOrEmpty(editSellPriceBox.Text)) { Program.InventoryManager.InventoryItems[index].SellPrice = double.Parse(editSellPriceBox.Text); }

                    // Clearing textBoxes
                    foreach (TextBox box in textBoxCollection)
                    {
                        box.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("There was no item found with a matching product number");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the product number before editing");
            }

            // Calling an event to refresh the inventory on MainMenu form
            EventHandler handler = this.RefreshInventory;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            // Checks if they filled the required forms
            if (!string.IsNullOrEmpty(restockProdNumBox.Text) && !string.IsNullOrEmpty(restockAmountBox.Text))
            {
                // Calls the InventoryManager restockItem() method
                Program.InventoryManager.restockItem(int.Parse(restockAmountBox.Text), int.Parse(restockProdNumBox.Text));
                // Clearing textBoxes
                restockAmountBox.Clear(); restockProdNumBox.Clear();
            }
            else
            {
                MessageBox.Show("Please fill the required text boxes before clicking the button");
            }

            // Calling an event to refresh the inventory on MainMenu form
            EventHandler handler = this.RefreshInventory;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
