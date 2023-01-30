using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Milestone
{
    public class Item
    {
        private static int id = 100;//will increment after assignment
        private int itemId;
        private string name;
        private double price;
        private int quantity;


        public Item()
        {

        }

        //main constructor
        public Item(string name, double price, int quantity)
        {
            this.itemId = id++;//assigns id number then increments
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        //constructor to assign id also. Only used when editing an Item
        public Item(int id, string name, double price, int quantity)
        {
            this.itemId = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        //generated getters and setters with quick actions and refactoring
        public global::System.Int32 ItemId { get => itemId; set => itemId = value; }
        public global::System.String Name { get => name; set => name = value; }
        public global::System.Double Price { get => price; set => price = value; }
        public global::System.Int32 Quantity { get => quantity; set => quantity = value; }

        //defines how to print out the item objects
        public override string ToString()
        {
            return this.itemId + "\t" + this.name + "\t" + this.price.ToString("c") + "\t" + this.quantity;
        }



    }
}
