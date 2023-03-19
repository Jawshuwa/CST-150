namespace Milestone_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Calling constructor for the InventoryManager object in Program.cs
            Program.InventoryManager = new InventoryManager();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            View_Menu view_Menu = new View_Menu();
            view_Menu.Show(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditMenu editMenu = new EditMenu();
            editMenu.Show(this);
        }
        
    }
}