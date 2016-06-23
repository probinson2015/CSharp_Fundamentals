using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //use a backslash before the character to escape the symbol
            //string myString = "My \"so-called\" life";

            // use backslash n "/n" for a new line
            //string myString = "What if I need a\nnew line?";

            //escaping the backslash
            //string myString = "Go to your c:\\drive";

            //escaping the backslash with an @ symbol
            //string myString = @"Go to your c:\ drive";

            //replacement codes can be used multiple times or in any order
            //string myString = String.Format("{0} = {1}", "First", "Second");

            //formatting currency
            //string myString = String.Format("{0:C}", 123.45);

            //add decimal points and commas to format large numbers
            //string myString = string.Format("{0:N}", 1234567890);

            //percentage format
            //string myString = string.Format("Percentage: {0:P}", .123);

            //custom formatting, use # for number. will go from right to left
            //so the numbers will push their way out and the very first character will
            //be pushed out to the left
            //string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);

            //string myString = "  All things can be learned ";

            //substring starts at the passed in position and returns everything
            //after that index, if passed two parameters, it stops at the second number
            //myString = myString.Substring(6);
            //myString = myString.Substring(2, 7);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");

            //start at first number, remove count of second number
            // myString = myString.Remove(4, 2);

            //use trim to remove spaces before and after
            //myString = String.Format("Length before: {0} -- Length after: {1}", 
            //    myString.Length, myString.Trim().Length);

            //this type of string concatenation is a lot of work in the background
            //best to use the StringBuilder class
            /*
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            //using the StringBuilder class to do string concatenation
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
