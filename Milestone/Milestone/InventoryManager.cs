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
            item.name = name;
            item.price = price;
            item.quantity = quantity;
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
            itemList.Sort((x,y) => x.name.CompareTo(y.name));
            sortType = "name";
        }

        public void SortID()
        {
            itemList.Sort((x, y) => x.itemId.CompareTo(y.itemId));
            sortType = "id";
        }

        public void SortPrice()
        {
            itemList.Sort((x, y) => x.price.CompareTo(y.price));
            sortType = "price";
        }

        public void SortQuantity()
        {
            itemList.Sort((x, y) => x.quantity.CompareTo(y.quantity));
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
            item.quantity = quantity;
        }

        //look through Item info to find match(es)
        public List<Item> Search(string searchText)
        {
            if(searchText == null || searchText.Equals(" ") || searchText.Equals("")) return itemList;//send the whole list because nothing to search for
            List<Item> searchList = new List<Item>();
            try
            {
                foreach(Item item in itemList)
                {
                    if(item.itemId.ToString().Contains(searchText.ToLower()) && !searchList.Contains(item)) searchList.Add(item);//search for id
                    if(item.name.ToLower().Contains(searchText.ToLower()) && !searchList.Contains(item)) searchList.Add(item);//search for name
                    if (item.price.ToString().Contains(searchText) && !searchList.Contains(item)) searchList.Add(item);//search for price
                    if (item.quantity.ToString().Contains(searchText) && !searchList.Contains(item)) searchList.Add(item);//search for quantity
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
