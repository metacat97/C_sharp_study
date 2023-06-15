using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempNum = 0; // 스왑할 때 임시로 넣을 공간인데용

            Random random = new Random();

            int buyNum;
            int gold = 500; //기본 소지 골드인데요오


            //아이템 생서자 생성
            item uniqueItem1 = new item();
            item uniqueItem2 = new item();
            item uniqueItem3 = new item();
            item uniqueItem4 = new item();
            item uniqueItem5 = new item();
            item uniqueItem6 = new item();
            item uniqueItem7 = new item();
            item uniqueItem8 = new item();
            item uniqueItem9 = new item();


            uniqueItem1.InitItem("종말의 검", 99999);
            uniqueItem2.InitItem("승리의 검", 2000);
            uniqueItem3.InitItem("완벽하게 벼려진 검", )
            uniqueItem4.InitItem("")
            uniqueItem5.InitItem("")
            uniqueItem6.InitItem("")
            uniqueItem7.InitItem("")
            uniqueItem8.InitItem("")
            uniqueItem9.InitItem("")










            //string[] userInventory = new string[4];
            //string[] shopInventory = new string[7];
            //string[] uniqueItem = new string[10];


            //아이템을 저장하고 있는 컬렉션을 만들고
            // 상점을 열면 -> 위의 컬렉션에서 랜덤으로 3가지 종류의 아이템을 출력한다.
            //상점을 일정 시간 (or) 열 때마다 아이템의 종류가 바뀐다.
            //플레이어는 가지고 있는 골드의 범위 안에서 아이템을 구매할 수 있다.
            //구매한 아이템은 플레이어의 인벤토리로 들어가고 출력해 볼 수 있다 .

            //game start = new game();

            //shop market = new shop();



            Console.WriteLine("====================================================================================");

            //start.printGame();

            Console.WriteLine("상점기능을 구현해보려고 해요");
            Console.WriteLine("그냥 하는 중인데");
            Console.WriteLine("");

            Console.WriteLine("num1번은 상점이고요 num2번은 유저 인벤토리예여");
            Console.WriteLine("");
            Console.WriteLine("나가시려면 Q 눌러주시면 되세요");
           



            List<string> userInventory = new List<string>();
            //사용자가 처음에 가지고 있는 아이템이ㅖㅇ요
            userInventory.Add("    목  검    ");
            userInventory.Add("  평범한 상의  ");
            userInventory.Add("  평범한 하의  ");
            userInventory.Add("  평범한 신발  ");


            
            

            List<string> shopInventory = new List<string>();
            // 상점에서 고정으로 보여질 아이템인거구요
            shopInventory.Add(" 철로 만든 투구 ");
            shopInventory.Add( " 철로 만든 상의 ");
            shopInventory.Add(" 철로 만든 하의 ");
            shopInventory.Add(" 철로 만든 신발 ");
            shopInventory.Add("   빨간 물약   ");
            shopInventory.Add("   파란 물약   ");
            shopInventory.Add("  핏빛 계약서  ");



            List<string> uniqueItem = new List<string>();
            //랜덤으로 갱신되는 유니크 아이템인 거예요
            uniqueItem.Add(" 유니크 아이템 0 ");
            uniqueItem.Add(" 유니크 아이템 1 ");
            uniqueItem.Add(" 유니크 아이템 2 ");
            uniqueItem.Add(" 유니크 아이템 3 ");
            uniqueItem.Add(" 유니크 아이템 4 ");
            uniqueItem.Add(" 유니크 아이템 5 ");
            uniqueItem.Add(" 유니크 아이템 6 ");
            uniqueItem.Add(" 유니크 아이템 7 ");
            uniqueItem.Add(" 유니크 아이템 8 ");
            uniqueItem.Add(" 유니크 아이템 9 ");
        


            //큰 틀의 반복문 시작
            while (true)
            {
                ConsoleKeyInfo something = Console.ReadKey();
                string user_input = Console.ReadLine();
                //탈출 조ㅓ건인ㄱㄷ[요
                if (something.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    break;
                }
                
                //큰 틀의 조건문이라구요
                if (something.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();

                    Console.WriteLine("상점입니다.");
                    Console.WriteLine("어서오세요.");
                    Console.WriteLine("어떤 걸 구매하실래요?");
                    Console.WriteLine("┌===========================================================┐");
                    Console.WriteLine("");
                    for (int i = 0; i < shopInventory.Count; i++)
                    {
                        Console.WriteLine("{0} {1}",i, shopInventory.ElementAt(i));
                        
                        if (user_input == shopInventory[i])
                        {
                            Console.WriteLine("잘 나왔어요");
                        }
                    }
                    Console.WriteLine("{0}", shopInventory[0]);
                    
                   

                }
                else if (something.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();

                    Console.WriteLine("유저 인벤토리");
                    Console.WriteLine("뭐가 있을까요?");

                    //클래스로 출력문은 뺄까 해요@@
                    Console.WriteLine("┌===========================================================┐");

                    Console.WriteLine("│");
                    Console.WriteLine("│");
                    Console.WriteLine("│");
                    Console.WriteLine("│");
                    Console.WriteLine("│");


                    Console.WriteLine("└==========================================================┘");

                }
            }
            // 큰 틀의 반복문이 끝







        }




    }
}
