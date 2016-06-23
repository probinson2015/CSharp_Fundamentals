using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Porsha's Big Giveaway");
            //Console.Write("Choose a door: 1,2,or 3: ");
            //string userValue = Console.ReadLine();

            //string message = "";

            //if (userValue == "1")
            //    message = "You chose 1, you win a new boat!";
            //else if (userValue == "2")
            //    message = "You chose 2, you win a new car!";
            //else if (userValue == "3")
            //   message = "You chose 3, you win a puppy!";
            //else
            //{
            //   message = "Sorry, please choose 1, 2, or 3 ";
            //   //message = message + "You Lose!";
            //   message += "You Lose!";
            //}
            //Console.WriteLine(message);
            //Console.ReadLine();

            Console.WriteLine("Porsha's Big Giveaway");
            Console.Write("Choose a door: 1,2,or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of hair";
            //Console.Write("You won a " + message + ".");
            Console.Write("You entered: {0}, therefore you won a {1}",userValue, message);
            Console.ReadLine();


        }
    }
}
