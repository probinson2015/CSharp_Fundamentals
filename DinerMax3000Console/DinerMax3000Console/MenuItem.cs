using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    //public because we want to be able to access it anywhere
    public class MenuItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        //using double since it will have decimals
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("You cannot have free or negative value items.");
                }
            }
        }

        //shadow property that is only accessible from within the class
        //shadow properties are usually denoted with an underscore
        private double _price;
        
      
   
    }
}
