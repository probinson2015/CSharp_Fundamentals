using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Honda";
            car1.Model = "Accord";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Ford";
            car2.Model = "Taurus";
            car2.VIN = "A2";

            Book b1 = new Book();
            b1.Author = "Porsha Robinson";
            b1.Title = "You can learn anything";
            b1.ISBN = "0-000-00000-0";
            */

            /*
            //ArrayLists are dynamically sized,
            //supports sorting, removal, etc.
            //cons are they are not strongly typed, you can put anything in an ArrayList.
            //this can cause errors like iterating through the list on a property
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            //List Collection
            List<Car> myCarList = new List<Car>();
            myCarList.Add(car1);
            myCarList.Add(car2);
            //myCarList.Add(b1);
            */

            /*
            //Dictionary Collection
            //Dictionary<TKey, TValue>
            Dictionary<string, Car> myCarDictionary = new Dictionary<string, Car>();
            myCarDictionary.Add(car1.VIN, car1);
            myCarDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myCarDictionary["A1"].Make);
            */

            //instantiating an array of strings with values
            //string[] names = { "Porsha", "Joe", "Enzo", "Romeo" };

            //instantiating an object with values
            //referred to as object initializer syntax
            //no need for a constructor
            Car car1 = new Car() { Make = "Honda", Model = "Accord", VIN = "P1" };
            Car car2 = new Car() { Make = "Toyota", Model = "Prius", VIN = "T2" };

            //collection initializer syntax
            List<Car> myCarList = new List<Car> { 
                new Car() { Make = "Honda", Model = "Accord", VIN = "P1" },
                new Car() { Make = "Toyota", Model = "Prius", VIN = "T2" }
            };
 
            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
