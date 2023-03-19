namespace Milestone_Project
{
    public partial class Restock : Form
    {
        public Restock()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            // Calling the restockItem method with the input values
            Program.InventoryManager.restockItem(int.Parse(valueBox.Text), int.Parse(prodNumberBox.Text));
        }
    }
}
