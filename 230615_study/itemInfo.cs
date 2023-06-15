using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230615_study
{


    internal class itemInfo
    {
        private string itemName;
        public int ItemCount { get; private set; }

        private int _itemPrice;

        public int itemCount { get; private set; }//접근 수준이 어느정도일까 ?


        public int itemPrice
        {
            get
            {
                return itemCount;
            }
            private set
            {
                _itemPrice = value;
            }
        }


        public void InitItem(string name, int count, int price)
        {
            itemName = name;
            itemCount = count;
            itemPrice = price;

        }

        //받는건 get  얻는건 set 
        public string Get_ItemName()
        {
            return itemName;
        }
        // 아이템 name 을 외부에서 변경할 수 있게 해주겠음

        public void set_ItemName(string changedName)
        {
            itemName = changedName;
        }


    }
}
