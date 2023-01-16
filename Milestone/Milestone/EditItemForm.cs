using System;
using System.Windows.Forms;

namespace Milestone
{
    public partial class EditItemForm : Form
    {
        private string itemName;
        private double itemPrice;
        private int itemQuantity;
        private MainInventoryForm mainInventoryForm;
        private Item item;

        public Item Item { get => item; set => item = value; }

        //constructor used to gather info from the mainInventoryForm that called it
        //to get selected Item info
        public EditItemForm(MainInventoryForm mainInventoryForm)
        {
            this.mainInventoryForm = mainInventoryForm;
            InitializeComponent();
        }

        //loads text box info and sets this.item info from the
        //Item that was selected in the MainInventoryForm
        private void EditItemForm_Load(object sender, EventArgs e)
        {
            itemNameTextBox.Text = this.mainInventoryForm.Transfer.Name;
            itemPriceTextBox.Text = this.mainInventoryForm.Transfer.Price.ToString();
            itemQuantityTextBox.Text = this.mainInventoryForm.Transfer.Quantity.ToString();
            this.item.ItemId = this.mainInventoryForm.Transfer.ItemId;
            this.item.Name = this.mainInventoryForm.Transfer.Name;
            this.item.Price = this.mainInventoryForm.Transfer.Price;
            this.item.Quantity = this.mainInventoryForm.Transfer.Quantity;
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

                        //edit item in maininventoryform
                        //Correctly updates the Item Object, but
                        //Doesn't update the text info in the list box even though the Item object info is changed
                        //https://stackoverflow.com/questions/26275462/listbox-selecteditem-edit-from-another-form
                        mainInventoryForm.Transfer.Name = itemName;
                        mainInventoryForm.Transfer.Price = itemPrice;
                        mainInventoryForm.Transfer.Quantity = itemQuantity;
                        mainInventoryForm.EditSelectedItem(item);

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
