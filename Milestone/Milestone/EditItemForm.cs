using System;
using System.Windows.Forms;

namespace Milestone
{
    public partial class EditItemForm : Form
    {
        private string itemName;
        private double itemPrice;
        private int itemQuantity;
        private InventoryManager inventoryManager;
        private Item item;

        //constructor used to gather info from the mainInventoryForm that called it
        //to get selected Item info
        public EditItemForm(InventoryManager inventoryManager, Item item)
        {
            InitializeComponent();
            this.inventoryManager = inventoryManager;
            this.item = item;
        }

        //loads text box info and sets this.item info from the
        //Item that was selected in the MainInventoryForm
        private void EditItemForm_Load(object sender, EventArgs e)
        {
            itemNameTextBox.Text = this.item.Name;
            itemPriceTextBox.Text = this.item.Price.ToString();
            itemQuantityTextBox.Text = this.item.Quantity.ToString();
            //this.item.ItemId = this.item.ItemId;
            //this.item.Name = this.item.Name;
            //this.item.Price = this.item.Price;
            //this.item.Quantity = this.item.Quantity;
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

                        //editItem method, send the original item and the changes to be made
                        inventoryManager.EditItem(item, itemName, itemPrice, itemQuantity);

                        //display change in message box
                        MessageBox.Show("Item Edited: " + itemName + ", " +
                        itemPrice.ToString("c") + ", " + itemQuantity.ToString());
                        Close();
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
