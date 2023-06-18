using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_0._01
{
    public class market
    {
        public void Shopping(ref int coin, ref List<Shopitem> inventory)
        {

            int tempNum = 0;
            Random random = new Random();
            int buyNum;


            Shopitem item1 = new Shopitem();
            Shopitem item2 = new Shopitem();
            Shopitem item3 = new Shopitem();
            Shopitem item4 = new Shopitem();
            Shopitem item5 = new Shopitem();
            Shopitem item6 = new Shopitem();

            item1.InitItem("나무", 30);
            item2.InitItem("달콤한 사탕", 20);
            item3.InitItem("집행검", 1300000);
            item4.InitItem("당신의 사랑", 50);
            item5.InitItem("고맙다", 80);
            item6.InitItem("모르겠다", 65);


            List<Shopitem> shop = new List<Shopitem>();
            List<Shopitem> shop2 = new List<Shopitem>();
           // List<Shopitem> inventory = new List<Shopitem>();
            shop.Add(item1);
            shop.Add(item2);
            shop.Add(item3);
            shop.Add(item4);
            shop.Add(item5);
            shop.Add(item6);


            for (int i = 0; i < 150; i++) //상점 아이템 순서 섞는 반복문
            {       // 임시 리스트에 랜덤순서 아이템 한개를 옮기고, 삭제한뒤 다시 추가해서 순서를 바꾼다.
                tempNum = random.Next(0, shop.Count);
                shop2.Add(shop.ElementAt(tempNum));
                shop.RemoveAt(tempNum);
                shop.Add(shop2.ElementAt(0));
                shop2.RemoveAt(0);
            }

            Console.WriteLine("어서오세요~ 아직 미구현이기에 맛만 보시고 가세요");
            Console.ReadKey();

            ConsoleKeyInfo keyInput;

            while (coin>=30)
            {
                Console.Clear();
                Console.WriteLine("Q = 종료");
                Printinven(inventory);
                keyInput = Console.ReadKey();
                switch (keyInput.Key)
                {
                    case ConsoleKey.Q:
                        return;
                    default:
                        ShuffleShop(shop, shop2);
                        Console.WriteLine("현재 보유 골드 : {0}\n\n", coin);
                        PrintShop(shop);
                        Console.WriteLine("\n아이템 번호를 입력시 아이템 구매를 진행하고, 4이상의 숫자를 입력시 상점을 리롤합니다.\n\n");
                        string Input = Console.ReadLine();
                        buyNum = int.Parse(Input);
                        if (buyNum < 4)
                        {
                            var item = shop[buyNum-1];
                            if (coin > item.itemPrice)
                            {
                                coin -= item.itemPrice;
                                Console.WriteLine("\n\n  {0}골드를 사용하여 아이템 {1}을 구매하셨습니다!", item.itemPrice, item.itemName);
                                inventory.Add(item);
                            }
                            else
                            {
                                Console.WriteLine("골드가 부족하여 아이템을 구매할 수 없습니다.");
                            }
                        }
                        Console.WriteLine("\n상점을 리롤합니다.");
                        Console.ReadKey();
                        break;

                }
            }
            Console.WriteLine("\n\n남은 골드로는 이제 아무것도 살수 없습니다. 상점을 종료합니다.\n\n");
        }

        static public void PrintShop(List<Shopitem> shop)
        {
            Console.WriteLine("┌──────────────────────────────상점──────────────────────────┐");
            for (int i = 0; i < 3; i++)
            {
                var item = shop[i];
                Console.WriteLine("│               {2,4}.  {0,4}  가격 : {1,4}                    ",
                    item.itemName, item.itemPrice, (i+1));
            }
            Console.WriteLine("└────────────────────────────────────────────────────────────┘");
        }

        static public void Printinven(List<Shopitem> inventory)
        {
            Console.WriteLine("┌───────────────────────────  가방  ─────────────────────────┐");
            for (int i = 0; i < inventory.Count; i++)
            {
                var item = inventory[i];
                Console.Write(" {0}, ",
                    item.itemName);
                if (i % 4 == 3)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n└────────────────────────────────────────────────────────────┘");

            Console.WriteLine("");

        }

        static public void ShuffleShop(List<Shopitem> shop, List<Shopitem> shop2)
        {
            Random random = new Random();
            int tempNum;
            Console.WriteLine();
            for (int i = 0; i < 10; i++) //상점 아이템 순서 섞는 반복문
            {       // 임시 리스트에 랜덤순서 아이템 한개를 옮기고, 삭제한뒤 다시 추가해서 순서를 바꾼다.
                tempNum = random.Next(0, shop.Count);
                shop2.Add(shop.ElementAt(tempNum));
                shop.RemoveAt(tempNum);
                shop.Add(shop2.ElementAt(0));
                shop2.RemoveAt(0);
            }
        }
    }
}
