using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    public class InventoryManager
    {
        public static string sortType { get; private set; }//keeps track of how the list is sorted
        private List<Item> itemList = new List<Item>();
        private Item item;
        public InventoryManager() { }

        //add item to the itemList
        public void AddNewItem(Item item) 
        { 
            itemList.Add(item);
        }

        //remove item
        public void RemoveItem(Item item) 
        { 
            itemList.Remove(item);
        }

        //edits the item
        public void EditItem(Item item, string name, double price, int quantity)
        {
            this.item = item;
            item.Name = name;
            item.Price = price;
            item.Quantity = quantity;
        }

        //get the item list
        public List<Item> GetItems()
        {
            return itemList;
        }

        //sort list by name of item
        //Got all of the sorting info from below
        //thanks to https://stackoverflow.com/questions/3309188/how-to-sort-a-listt-by-a-property-in-the-object
        public void SortName()
        {
            itemList.Sort((x,y) => x.Name.CompareTo(y.Name));
            sortType = "name";
        }

        public void SortID()
        {
            itemList.Sort((x, y) => x.ItemId.CompareTo(y.ItemId));
            sortType = "id";
        }

        public void SortPrice()
        {
            itemList.Sort((x, y) => x.Price.CompareTo(y.Price));
            sortType = "price";
        }

        public void SortQuantity()
        {
            itemList.Sort((x, y) => x.Quantity.CompareTo(y.Quantity));
            sortType = "quantity";
        }
        
        //method that will help with adding and editing Items, so they can be sorted into existing list
        public void AutoSort()
        {
            switch (sortType)
            {
                case "name": SortName(); break;
                case "id": SortID(); break;
                case "price": SortPrice(); break;
                case "quantity": SortQuantity(); break;
                default: SortID(); break;
            }
        }

        //restock an item (change the quantity)
        public void Restock(Item item, int quantity)
        {
            this.item = item;
            item.Quantity = quantity;
        }

        //look through Item info to find match(es)
        public List<Item> Search(string searchText)
        {
            if(searchText == null || searchText.Equals(" ") || searchText.Equals("")) return itemList;//send the whole list
            List<Item> searchList = new List<Item>();
            try
            {
                foreach(Item item in itemList)
                {
                    if(item.ItemId.ToString().Contains(searchText.ToLower()) && !searchList.Contains(item)) searchList.Add(item);
                    if(item.Name.ToLower().Contains(searchText.ToLower()) && !searchList.Contains(item)) searchList.Add(item);
                    if(item.Price.ToString().Contains(searchText) && !searchList.Contains(item)) searchList.Add(item);
                    if(item.Quantity.ToString().Contains(searchText) && !searchList.Contains(item)) searchList.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Items Found");
            }
            return searchList;
        }
    }
}
