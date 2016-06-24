using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    //want the Menu to be available from everywhere so made it public
    public class Menu
    {
        //menu constructor
        public Menu()
        {
            items = new List<MenuItem>();
        }

        //menu name
        public string Name;
        //list of menu items
        //this property is instantiated in the constructor of the Menu class
        public List<MenuItem> items;

       public void AddMenuItem(string title, string description, double price)
        {
            //create new item
            MenuItem item = new MenuItem() { Title = title, Description = description, Price = price };

            //add item to the items list
            items.Add(item);
        } 
    }
}
