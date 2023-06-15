using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class everyItem
    {
        //공용 관리
        Dictionary<string, int> everything = new Dictionary<string, int>();
        Dictionary<string, string> everyItemCode = new Dictionary<string, string>();

        //상점 관리
        Dictionary<string, string> shopItemCode = new Dictionary<string, string>();
        Dictionary<string, int> shopFixInvetory = new Dictionary<string, int>();

        //유저 인벤 관리
        Dictionary<string, int> userInven = new Dictionary<string, int>();
        Dictionary<string, string> userItemCode = new Dictionary<string, string>();


        public void allItem()
        {
            //모든 아이템 추가 및 관리
            everything.Add(" 체력 물약 ", 150);
            everything.Add(" 마나 물약 ", 150);
            everything.Add("    철    ", 50);
            everything.Add("  구 리   ", 30);
            everything.Add("  생 수   ", 10);
            everything.Add("  철 검   ", 1000);
            everything.Add(" 구리 방패 ", 500);
            everything.Add(" 뾰족한 모자", 2000);
            everything.Add("  면 바지", 3000);
            everything.Add(" 하얀 신발 ", 1500);
            everything.Add("    흙     ", 10);
            everything.Add(" 나무 목검 ", 100);
            everything.Add(" 낡은 바지 ", 500);
            everything.Add(" 낡은 상의 ", 500);

            everyItemCode.Add("1", " 체력 물약 ");
            everyItemCode.Add("2", " 마나 물약 ");
            everyItemCode.Add("4", "    철    ");
            everyItemCode.Add("5", "   구 리   ");
            everyItemCode.Add("6", "   생 수   ");
            everyItemCode.Add("7", "   철 검   ");
            everyItemCode.Add("8", "  구리 방패 ");
            everyItemCode.Add("9", " 뾰족한 모자 ");
            everyItemCode.Add("10", "  면 바지  ");
            everyItemCode.Add("11", " 하얀 신발 ");
            everyItemCode.Add("12", "    흙     ");
            everyItemCode.Add("13", " 나무 목검 ");
            everyItemCode.Add("14", " 낡은 바지 ");
            everyItemCode.Add("15", " 낡은 상의 ");

        }
        public void shopItem()
        {
            string[] items = new string[10];
            int keyIndex = 0;

            

            //상점 아이템 추가 및 관리
            shopFixInvetory.Add(" 체력 물약 ", 150);
            shopFixInvetory.Add(" 마나 물약 ", 150);
            shopFixInvetory.Add("    철    ", 50);
            shopFixInvetory.Add("  구 리   ", 30);
            shopFixInvetory.Add("  생 수   ", 10);
            shopFixInvetory.Add("  철 검   ", 1000);
            shopFixInvetory.Add(" 구리 방패 ", 500);
            shopFixInvetory.Add(" 뾰족한 모자", 2000);
            shopFixInvetory.Add("  면 바지", 3000);
            shopFixInvetory.Add(" 하얀 신발 ", 1500);

            shopItemCode.Add("1", " 체력 물약 ");
            shopItemCode.Add("2", " 마나 물약 ");
            shopItemCode.Add("4", "    철    ");
            shopItemCode.Add("5", "   구 리   ");
            shopItemCode.Add("6", "   생 수   ");
            shopItemCode.Add("7", "   철 검   ");
            shopItemCode.Add("8", "  구리 방패 ");
            shopItemCode.Add("9", " 뾰족한 모자 ");
            shopItemCode.Add("10", "  면 바지  ");
            shopItemCode.Add("11", " 하얀 신발 ");


            foreach (string key in shopFixInvetory.Keys)
            {
                items[keyIndex] = key;

                keyIndex += 1;
            }
        }

        public void userInvetory()
        {
            //유저 인벤 아이템 추가
            //아이템 추가 
            userInven.Add("    흙     ", 10);
            userInven.Add(" 나무 목검 ", 100);
            userInven.Add(" 낡은 바지 ", 500);
            userInven.Add(" 낡은 상의 ", 500);
            //코드 추가
            userItemCode.Add("12", "    흙     ");
            userItemCode.Add("13", " 나무 목검 ");
            userItemCode.Add("14", " 낡은 바지 ");
            userItemCode.Add("15", " 낡은 상의 ");


        }
    }
}
