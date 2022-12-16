using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    public partial class MainInventoryForm : Form
    {
        public MainInventoryForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.ShowDialog();
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            EditItemForm editItemForm = new EditItemForm();
            editItemForm.ShowDialog();
        }
    }
}
