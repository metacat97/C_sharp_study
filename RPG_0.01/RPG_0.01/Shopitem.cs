﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_0._01
{
    public class Shopitem
    {
        public string itemName;
        public int itemPrice;

        public void InitItem(string name, int price)
        {
            itemName = name;
            itemPrice = price;
        }
    }
}
