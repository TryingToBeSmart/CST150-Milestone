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

            //construct some inventory items
            Item baseballs = new Item("Baseball", 5.50, 200);
            Item glove = new Item("Glove", 69.99, 14);
            Item football = new Item("Football", 25.99, 9);
            Item golfClub = new Item("Golf Club", 79.99, 12);

            //add items into the list box
            AddNewItem(baseballs);
            AddNewItem(glove);
            AddNewItem(football);
            AddNewItem(golfClub);

            //select the first items
            selectTopItem();
        }

        //select the first items
        public void selectTopItem()
        {
            try
            {
                inventoryList.SelectedIndex = 0;
            }
            catch (Exception)
            {
                //do nothing
            }
        }

        //add items to inventorylist box
        public void AddNewItem(Item item)
        {
            inventoryList.Items.Add(item);
        }

        //"edits" selected item by replaceing it with a new Item that is generated from the EditItemForm
        public void EditSelectedItem(Item item)
        {
            inventoryList.Items[inventoryList.SelectedIndex] = new Item(item.ItemId, item.Name, item.Price, item.Quantity);
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm(this);
            addItemForm.ShowDialog();
        }

        //edits the current item selected in the item list
        private void editItemButton_Click(object sender, EventArgs e)
        {
            //if item selected
            if (inventoryList.SelectedItems.Count > 0)
            {
                EditItemForm editItemForm = new EditItemForm(this);
                Item tempValue = (Item)inventoryList.Items[inventoryList.SelectedIndex];
                editItemForm.Item = tempValue;
                editItemForm.ShowDialog();
            }
            else MessageBox.Show("Select Item To Edit");
        }

        //Used to transfer Item to and from the edit item form 
        //from https://stackoverflow.com/questions/19449048/pass-listbox-item-to-a-textbox-on-another-form-c-sharp
        public Item Transfer
        {
            get { return (Item)inventoryList.SelectedItem; }
            set
            {
                inventoryList.SelectedItem = value;
                inventoryList.Refresh();
            }

        }

        //Remove selected item
        private void removeItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventoryList.Items.RemoveAt(inventoryList.SelectedIndex);
                inventoryList.Refresh();//I don't really know what this does, but it recommended usnig refresh            
                selectTopItem();//select the first item
            }
            catch (Exception)
            {
                //if nothing selected, do nothing
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
