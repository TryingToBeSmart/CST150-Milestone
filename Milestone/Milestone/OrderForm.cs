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
    public partial class OrderForm : Form
    {
        Item item;
        InventoryManager inventoryManager;

        public OrderForm(InventoryManager inventoryManager, Item item)
        {
            InitializeComponent();
            this.item = item;
            this.inventoryManager = inventoryManager;
        }

        //set title of the page with the item name
        private void OrderForm_Load(object sender, EventArgs e)
        {
            title.Text = "Order " + item.name;
        }

        //add amount entered into the text box to the quantity
        private void enterButton_Click(object sender, EventArgs e)
        {
            int amount;
           // while (true)
            {
                if (int.TryParse(quantityTextBox.Text, out amount))
                {
                    item.quantity = item.quantity += amount;
                    MessageBox.Show("Ordered " + amount);
                    DialogResult = DialogResult.OK;
                   // break;
                }
                else
                {
                    MessageBox.Show("Incorrect Input");
                    quantityTextBox.Text = "";
                    quantityTextBox.Select();
                }
            }
            
        }
    }
}
