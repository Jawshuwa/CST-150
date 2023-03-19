namespace Milestone_Project
{
    public partial class EditMenu : Form
    {
        public EditMenu()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddInventory addInventory = new AddInventory();
            addInventory.Show(this);

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Remove remove = new Remove();
            remove.Show(this);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            Restock restock = new Restock();
            restock.Show(this);
        }
    }
}
