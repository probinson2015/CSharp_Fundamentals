using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate new menu
            FoodMenu summerMenu = new FoodMenu();
            //set the name for the menu
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon with Sandefjord butter.", 25.50);
            summerMenu.AddMenuItem("Turkey Burger", "Fresh grilled Turkey burger with Swiss cheese", 8.50);
            summerMenu.HospitalDirections = "Head North on Main St. Turn left on Blanchard.";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drinkand code.";
            outsideDrinks.AddMenuItem("Bloody Mary", "Spicy!", 7.50);
            outsideDrinks.AddMenuItem("Long Island", "Strong!", 8.00);

            Order hungryGuestOrder = new Order();

            //add all items from summer menu and drink menu to hungry guest order
            foreach (MenuItem item in summerMenu.items)
            {
                hungryGuestOrder.items.Add(item);
            }
            foreach (MenuItem item in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(item);
            }

            Console.WriteLine("hungryGuestOrder Total is: {0:C}", hungryGuestOrder.Total);

            //testing applicationException
            try
            {
                outsideDrinks.AddMenuItem("White Russian", "Creamy!", 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
