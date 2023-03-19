using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Clearing any previous searchs 
            searchListBox.Items.Clear();
            string searchResults;
            // Checks if either radio buton was checked
            if (productName.Checked || productNumber.Checked)
            {
                // Changes the searchItem method parameter depending on which was checked
                if (productName.Checked)
                {
                    searchResults = Program.InventoryManager.searchItem(searchParameter.Text);
                }
                else
                {
                    searchResults = Program.InventoryManager.searchItem(int.Parse(searchParameter.Text));
                }
                searchListBox.Items.Add(searchResults.ToString());
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
