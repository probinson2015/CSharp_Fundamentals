using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            //month day year hour minute seconds AM/PM
            //Console.WriteLine(myValue.ToString());

            //month day year
            //Console.WriteLine(myValue.ToShortDateString());

            //hour and minute with AM/PM
            //Console.WriteLine(myValue.ToShortTimeString());

            //weekday month day year - spelled out
            //Console.WriteLine(myValue.ToLongDateString());

            //hours minutes seconds with AM/PM
            //Console.WriteLine(myValue.ToLongTimeString());

            //add days
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            //add hours
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            //subtract days, use a negative argument
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //returns an Integer
            //Console.WriteLine(myValue.Month);

            //creating a new DateTime object giving parameters of year, month, day
            //DateTime myBirthday = new DateTime(1982, 10, 23);
            //Console.WriteLine(myBirthday.ToLongDateString());

            //taking a string and parsing into a date
            DateTime myBirthday = DateTime.Parse("10/23/1982");

            //represent a span of time
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine("You have been alive for {0} days!" , myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
