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
    public partial class EditItemForm : Form
    {
        private string itemName;
        private decimal itemPrice;
        private int itemQuantity;

        public EditItemForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            if (!itemNameTextBox.Text.Equals(""))
            {//if text box is not blank
                nameErrorLabel.Text = "";//clear error
                itemName = itemNameTextBox.Text;

                //get price from text box
                if (decimal.TryParse(itemPriceTextBox.Text, out itemPrice))
                {
                    priceErrorLabel.Text = "";//clear error

                    //get quantity from text box
                    if (int.TryParse(itemQuantityTextBox.Text, out itemQuantity))
                    {
                        //all input is correct
                        quantityErrorLabel.Text = "";//clear error
                        MessageBox.Show("Item Edited: " + itemName + ", " +
                        itemPrice.ToString("c") + ", " + itemQuantity.ToString());
                    }

                    //else display quantity error
                    else quantityErrorLabel.Text = "Enter a number";
                }

                //else display price error
                else priceErrorLabel.Text = "Enter a number";
            }

            //else display name error
            else nameErrorLabel.Text = "Enter a name";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
