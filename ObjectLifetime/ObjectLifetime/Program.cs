using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();

            myCar.Make = "Honda";
            myCar.Model = "Accord";
            //myCar.Year = 2007;
            myCar.Color = "Blue";

            //creating a copy of the memory address, they are accessing the same object
            //Car myOtherCar = myCar;

            //Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Year, myOtherCar.Make,
            //    myOtherCar.Model, myOtherCar.Color);

            //myOtherCar.Model = "Civic";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Year, myCar.Make,
                myCar.Model, myCar.Color);

            Car myThirdCar = new Car("Porsche", "Carrera", 2016, "Red");
            Console.WriteLine(myThirdCar.Model);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //constructor
        public Car()
        {
            //optional way
            //this.Year = 2007;

            Year = 2014;

            //You could load from a config file, database, etc.
        }

        //overload constructor
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

    }
}
