using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Honda";
            myCar.Model = "Accord";
            myCar.Year = 2007;
            myCar.Color = "Blue";

            // (1/2) this was a manual way to determine value
            //decimal value = DetermineMarketValue(myCar);

            Console.Write("{2} {3} {0} {1} \nPrice: {4:C}",
                myCar.Make, myCar.Model,
                myCar.Year, myCar.Color,
                myCar.DetermineMarketValue());

            Console.ReadLine();
        }

        //(2/2)instead of making the method here, I added it to the Car class

        //private static decimal DetermineMarketValue(Car car)
        //{
        //    //someday I  may use an online web service to get more accurate value
        //    //for now it is hard coded

        //    //have to have M after the number in order for it to be a decimal?
        //    decimal carValue = 7000.00M;
        //    return carValue;
        //}
    }


    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
        }

    }
}
