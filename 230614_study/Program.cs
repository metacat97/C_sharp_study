using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230614_study
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> myInventory = new Dictionary<string, int>();
            myInventory.Add("빨간 포션", 5);
            myInventory.Add("골드", 500);
            myInventory.Add("몰락한 왕의 검", 1);
            //무작위 서치 하려고 만든 자료구조구요 
            // 비선형 데이터 구조예요 

            ItemInfo redpotion = new ItemInfo(); 
            ItemInfo gold = new ItemInfo();
            ItemInfo sword = new ItemInfo();

            redpotion.InitItem("빨간 포션", 5, 100);
            gold.InitItem("골드", 500, 1);
            sword.InitItem("몰락한 왕의 검", 1, 39800);

            
            Dictionary<string, ItemInfo> myInventory2 = new Dictionary<string, ItemInfo>();
            myInventory2.Add("빨간포션", redpotion);
            myInventory2.Add("골드", gold);
            myInventory2.Add("몰락한 왕의 검", sword);




            foreach (var item in myInventory2)
            {
                Console.WriteLine("아이템{0}   갯수 = {1}    가격 = {2} ",
                    item.Value.itemName, item.Value.itemCount, item.Value.itemPrice);

            }





            //for(int i = 0; i <my)//카운트로 접근 못해요

            foreach (KeyValuePair<string, int> item in myInventory) //이걸로 접근해야 해요.
            {
                Console.WriteLine("아이템 이름 : {0}, 아이템 갯수:{1}", item.Key, item.Value);

            }
            Console.WriteLine("아이템 갯수: {0}", myInventory["빨간 포션"]);
        }


        public static void desc001()
        {
            //막상 쓸려고 하니까 함수가 없다.
            // 쓸려면 선언을 해야함
            //print001 printClass = new print001();
            //printClass.PrintMessage("Hello world!");

            print002.PrintMessage("Hello World!");


            List<int> num = new List<int>();
            Console.WriteLine("{0} <---- 내 리스트 크기 입니당", num.Count);


            for (int i = 0; i <num.Count; i++)
            {
                //num.Add(i+1);

                if (i % 2 == 1)
                {
                    Console.WriteLine("내가 지우려는 데이터->{0}", num[i]);
                    Console.WriteLine("{0}");
                    num.RemoveAt(i);
                }
            }

            foreach (int n in num)
            {
                Console.WriteLine("{0}", n);
            }


        }
    }
}
