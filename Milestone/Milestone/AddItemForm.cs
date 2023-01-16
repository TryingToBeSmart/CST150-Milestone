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
    public partial class AddItemForm : Form
    {
        private string itemName;
        private double itemPrice;
        private int itemQuantity;
        MainInventoryForm mainInventoryForm;
        Item newItem;

        public AddItemForm(MainInventoryForm mainInventoryForm)
        {
            this.mainInventoryForm = mainInventoryForm;
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (!itemNameTextBox.Text.Equals(""))
            {//if text box is not blank
                nameErrorLabel.Text = "";//clear error
                itemName = itemNameTextBox.Text;

                //get price from text box
                if (double.TryParse(itemPriceTextBox.Text, out itemPrice))
                {
                    priceErrorLabel.Text = "";//clear error

                    //get quantity from text box
                    if (int.TryParse(itemQuantityTextBox.Text, out itemQuantity))
                    {
                        //all input is correct
                        quantityErrorLabel.Text = "";//clear error
                    
                        //create new item
                        newItem = new Item(itemName, itemPrice, itemQuantity);

                        //send new item to main inventory form list box
                        mainInventoryForm.AddNewItem(newItem);

                        //automatically select the first item
                        mainInventoryForm.selectTopItem();

                        //display in message box
                        MessageBox.Show("Item Added: " + itemName + ", " +
                            itemPrice.ToString("c") + ", " + itemQuantity.ToString());

                        //clear text boxes
                        itemNameTextBox.Text = "";
                        itemPriceTextBox.Text = "";
                        itemQuantityTextBox.Text = "";

                        //send curser to name text box
                        itemNameTextBox.Select();

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
