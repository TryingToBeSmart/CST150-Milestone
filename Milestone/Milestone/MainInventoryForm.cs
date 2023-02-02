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
        InventoryManager inventoryManager = new InventoryManager();
        public MainInventoryForm()
        {
            InitializeComponent();
            

            //construct and add items into the inventory manager
            inventoryManager.AddNewItem(new Item("Baseball", 5.50, 200));
            inventoryManager.AddNewItem(new Item("Glove", 69.99, 14));
            inventoryManager.AddNewItem(new Item("Football", 25.99, 9));
            inventoryManager.AddNewItem(new Item("Golf Club", 79.99, 12));
            inventoryManager.AddNewItem(new Item("Cleats", 99.99, 8));

            inventoryManager.SortID();//sort by ID number

            //add all items from the inventory manager into the inventoryList in the form
            inventoryListBox.Items.AddRange(inventoryManager.GetItems().ToArray());

            //select the first items
            selectTopItem();
        }

        //select the first items
        public void selectTopItem()
        {
            try
            {
                inventoryListBox.SelectedIndex = 0;//select first item
            }
            catch (Exception)
            {
                //do nothing if the list is empty
            }
        }

        //clear the list box contents and re-add them based on the sorted inventoryManager list
        public void RefreshList()
        {
            inventoryManager.AutoSort();
            inventoryListBox.Items.Clear();
            inventoryListBox.Items.AddRange(inventoryManager.Search(searchTextBox.Text).ToArray());//add the sorted list(with search text) back to the list box
        }

        //Opens the AddItemForm 
        private void addItemButton_Click(object sender, EventArgs e)
        {

            //send inventoryManager object to the AddItemForm
            using (AddItemForm addItemForm = new AddItemForm(inventoryManager))
            {
                if (addItemForm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)//back button selected
                {
                    RefreshList();//when addItemForm is closed, refresh the list box
                }
            }
        }

        //edits the current item selected in the item list
        private void editItemButton_Click(object sender, EventArgs e)
        {
            //if item selected
            if (inventoryListBox.SelectedItems.Count > 0)
            {
                using (EditItemForm editItemForm = new EditItemForm(inventoryManager, (Item)inventoryListBox.SelectedItem))//open edit form with item selected
                {
                    if (editItemForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)//enter button selected
                    {
                        RefreshList();//when addItemForm is closed, refresh the list box
                    }
                }
            }
            else MessageBox.Show("Select Item To Edit");//no item selected
        }

        //Remove selected item
        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedItems.Count > 0)//if item selected
            {
                using (Remove remove = new Remove((Item)inventoryListBox.SelectedItem))//open remove form with item selected
                {
                    if (remove.ShowDialog() == System.Windows.Forms.DialogResult.OK)//yes button selected
                    {
                        inventoryManager.RemoveItem((Item)inventoryListBox.SelectedItem);//remove item
                        RefreshList();
                    }

                }
            }

            else MessageBox.Show("Select Item To Remove");//no item selected
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        //activate Sort by Id and change button colors
        private void sortIDButton_Click(object sender, EventArgs e)
        {
            //change the colors of the selected button
            sortIDButton.BackColor = SystemColors.ControlDark;
            sortAZButton.BackColor = SystemColors.ScrollBar;
            sortPriceButton.BackColor = SystemColors.ScrollBar;
            sortQuantityButton.BackColor = SystemColors.ScrollBar;

            //sort the item list by ID            
            inventoryManager.SortID();//sort items by ID
            RefreshList();//refresh the list box
        }

        private void sortAZButton_Click(object sender, EventArgs e)
        {
            //change the colors of the selected button
            sortIDButton.BackColor = SystemColors.ScrollBar;
            sortAZButton.BackColor = SystemColors.ControlDark;
            sortPriceButton.BackColor = SystemColors.ScrollBar;
            sortQuantityButton.BackColor = SystemColors.ScrollBar;

            //sort the item list by name
            inventoryManager.SortName();//sort items by name
            RefreshList();//refresh the list box
        }

        private void sortPriceButton_Click(object sender, EventArgs e)
        {

            //change the colors of the selected button
            sortIDButton.BackColor = SystemColors.ScrollBar;
            sortAZButton.BackColor = SystemColors.ScrollBar;
            sortPriceButton.BackColor = SystemColors.ControlDark;
            sortQuantityButton.BackColor = SystemColors.ScrollBar;

            //sort the item list by price
            inventoryManager.SortPrice();//sort items by price
            RefreshList();//refresh the list box
        }

        private void sortQuantityButton_Click(object sender, EventArgs e)
        {
            //change the colors of the selected button
            sortIDButton.BackColor = SystemColors.ScrollBar;
            sortAZButton.BackColor = SystemColors.ScrollBar;
            sortPriceButton.BackColor = SystemColors.ScrollBar;
            sortQuantityButton.BackColor = SystemColors.ControlDark;

            //sort the item list by quantity inventoryListBox.Items.Clear();//clear the items in the list box
            inventoryManager.SortQuantity();//sort items by quantity
            RefreshList();//refresh the list box
        }
            //shows the items that match the search
            //Not currently using
            private void searchButton_Click(object sender, EventArgs e)
        {
            inventoryListBox.Items.Clear();//clear the items in the list box
            inventoryListBox.Items.AddRange(inventoryManager.Search(searchTextBox.Text).ToArray());
        }

        //show the items that match the search as the text changes
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            inventoryListBox.Items.Clear();//clear the items in the list box
            inventoryListBox.Items.AddRange(inventoryManager.Search(searchTextBox.Text).ToArray());
        }

        //order more of the item
        private void reorderItemButton_Click(object sender, EventArgs e)
        {
            //if item selected
            if (inventoryListBox.SelectedItems.Count > 0)//if item is selected
            {
                using (OrderForm orderForm = new OrderForm(inventoryManager, (Item)inventoryListBox.SelectedItem))//new order form with item
                {
                    if (orderForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)//if order form enter button is clicked
                    {
                        RefreshList();//when addItemForm is closed, refresh the list box
                    }
                }
            }
            else MessageBox.Show("Select Item To Order");//no item selected
        }

        //add items to inventorylist box
        //Not being used after implementing InventoryManager Class
        public void AddNewItem(Item item)
        {
            inventoryListBox.Items.Add(item);
        }

        //"edits" selected item by replaceing it with a new Item that is generated from the EditItemForm
        //Not being used after implementing InventoryManager Class
        public void EditSelectedItem(Item item)
        {
            inventoryListBox.Items[inventoryListBox.SelectedIndex] = new Item(item.itemId, item.name, item.price, item.quantity);
        }
    }
}
