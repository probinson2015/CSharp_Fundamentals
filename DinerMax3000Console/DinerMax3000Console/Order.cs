﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Order
    {
        //list of menu items for the order
        public List<MenuItem> items = new List<MenuItem>();
        public double Total
        {
            get
            {
                double calculatedTotal = 0;
                foreach (MenuItem item in items)
                {
                    calculatedTotal += item.Price;
                }
                return calculatedTotal;
            }
        }
    }
}
