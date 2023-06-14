using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230614_study
{
    internal class ItemInfo
    {
        public string itemName;
        public int itemCount;
        public int itemPrice;
         
        public void InitItem(string name, int count, int price)
        {
            itemName = name;
            itemPrice = price;
            itemCount = count;
        }

       // public inItitem()
    }
}
