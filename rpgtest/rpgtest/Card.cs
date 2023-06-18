using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace rpgtest
{
    public class Card
    {
        int coinCount = 0;
        public void printScreen()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                      │");
            Console.WriteLine("│                                                                                      │");
            Console.WriteLine("│                                                                                      │");
            Console.WriteLine("│                                  카드 맞 추 기                                       │ ");
            Console.WriteLine("│                                                                                      │");
            Console.WriteLine("│                                                                                      │");
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────┘");
        }


        public void cardGame(ref int coin)
        {
            int pcCard1 = 0;
            int pcCard2 = 0;
            int userCard = 0;


            int Betting = 0;
            

            string bettingCoin = default;

            int[] pcCard = new int[2];

            Random cardrand = new Random(); 
            string[] cards = { "♣2", "◇2", "♡2", "♠2", "♣3", "◇3", "♡3", "♠3", "♣4", "◇4", "♡4", "♠4",
           "♣5", "◇5", "♡5", "♠5", "♣6", "◇6", "♡6", "♠6", "♣7", "◇7", "♡7", "♠7",
           "♣8", "◇8", "♡8", "♠8", "♣9", "◇9", "♡9", "♠9", "♣10", "◇10", "♡10", "♠10",
           "♣J", "◇J", "♡J", "♠J", "♣Q", "◇Q", "♡Q", "♠Q", "♣K", "◇K", "♡K", "♠K", "♣A", "◇A", "♡A", "♠A" };


          


            while (true)
            {
                ConsoleKeyInfo something = Console.ReadKey();

                //탈출 조건
                if (coin == 0)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }
                
                if (something.Key == ConsoleKey.Q)
                {
                    
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }

                
                //Console.ReadKey();
                Console.Clear();

                pcCard1 = cardrand.Next(1, cards.Length-1);
                pcCard2 = cardrand.Next(1, cards.Length-1);
                userCard = cardrand.Next(1, cards.Length-1);
                Console.WriteLine("트럼프 카드 2장 중 사이에 값이 있다면 당신의 승리");
                Console.WriteLine("섞는중...");
                Thread.Sleep(1000);
                


                Console.Clear();
                printScreen();
                Console.WriteLine("트럼프 카드 2장 중 사이에 값이 있다면 당신의 승리");
                Console.WriteLine("현재 당신의 잔여 코인 = {0}", coin);

                // 큰 값 비교 쉽게 하기 위해서  대입
              
                
                pcCard[0] = pcCard1;
                pcCard[1] = pcCard2;

                // 큰 값 비교 로직
                if (pcCard[0] > pcCard[1])
                {
                    int temp = 0;
                    temp = pcCard[0];
                    pcCard[0] = pcCard[1];
                    pcCard[1] = temp;
                }

                Console.WriteLine("{0} ~ {1} 사이에 있으면 됩니다.", cards[pcCard[0]], cards[pcCard[1]]);
                Console.WriteLine("넣을 코인을 입력해주세요.");
                bettingCoin = Console.ReadLine();
                int.TryParse(bettingCoin, out Betting);
                


                //연산 로직
                if (userCard >= pcCard[0] &&  userCard <= pcCard[1])
                {
                    // Console.WriteLine("승리하여 베팅 코인에 2배 획득\n");
                    coin = coin + (Betting * 2);
                    Console.WriteLine("coin = = = {0}", coin);
                    // break;
                }
                else
                {
                    //Console.WriteLine("패배하여 베팅한 코인[%d]만큼 잃었습니다.\n",betting_coin);
                    coin = coin - Betting;
                    //  break;
                }

                Console.WriteLine("결과는 {0} :::  베팅은 {1}",coin, Betting);

                Console.WriteLine("종료하시려면 Q키   계속 하시려면 아무키나 눌러주세요 ");
                //Console.ReadKey();

            }
        }



    }
}
