namespace Milestone_Project
{
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prodNumber = int.Parse(productNumber.Text);
            Program.InventoryManager.removeItem(prodNumber);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
