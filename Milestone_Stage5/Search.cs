using Milestone_Project;

namespace Milestone_v1._5
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Clearing the listBox
            searchListBox.Items.Clear();
            // Creating a List of strings to hold all search results
            List<string> searchResults;
            // Check if either radio button was pressed
            if (prodNameButton.Checked || prodNumButton.Checked)
            {
                // Whichever is checked, will determine which searchItem() method is called
                if (prodNameButton.Checked)
                {
                    searchResults = Program.InventoryManager.searchItem(searchTermBox.Text);
                }
                else
                {
                    searchResults = Program.InventoryManager.searchItem(int.Parse(searchTermBox.Text));
                }
                foreach (string item in searchResults)
                {
                    // Adds each item that matches the search results
                    searchListBox.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Please select one of the search options");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
