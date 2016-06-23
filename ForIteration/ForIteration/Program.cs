using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    //Console.WriteLine(i);
                    Console.WriteLine("Found Seven!");
                    break;
                }
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {

            }

            Console.ReadLine();
        }
    }
}
