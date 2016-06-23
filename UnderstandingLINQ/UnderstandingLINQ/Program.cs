using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            /*
            //LINQ query syntax
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;


            */

            /*
            var orderedCars = from car in myCars
                              orderby car.Make ascending
                              select car;
            */




            //LINQ method syntax
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            //var orderedCars = myCars.OrderBy(p => p.Make);

            //find first item from sorted list
            //var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");

            //Console.WriteLine(firstBMW.VIN);



            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0}, {1}, {2}", car.Make, car.Model, car.VIN);

            }
            */

            //returns true or false based on aggregrated comparison
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2005));

            //LINQ ForEach statement
            //subtracting from a value
            //myCars.ForEach(p => p.StickerPrice -= 3000);

            //then showing the value after it's been subtracted
            // myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //returns true or false
            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            //sum properties of a collection
            //Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));

           

            var orderedCars = myCars.OrderBy(p => p.Make);
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
               
            //selecting cars and projecting them into a new datatype 
            var newCars = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make, car.Model };

            Console.WriteLine(newCars.GetType());

            Console.WriteLine("My List<Car> of cars have type: {0}", myCars.GetType());
            Console.WriteLine("My ordered list of cars have type: {0}", orderedCars.GetType());
            Console.WriteLine("My bmws 'where type is' has type: {0}", bmws.GetType());



            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
