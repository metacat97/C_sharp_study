using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokergame
{
     public class Program
    {
   

        static void Main(string[] args)
        {
            Random rand = new Random(); //랜덤 인스턴스 생성 
            //랜덤 번호 저장할 변수
            int pcCheckNumber = 0;
            int userCheckNumber = 0;
            




            List<string> card = new List<string>(); // 리스트 인스턴스 생성
            //스트링 배열 선언
            string[] pattern = { "♠", "◆", "♥", "♣" };
            string[] numbers = { "A ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10 ", "J ", "Q ", "K " };

            //리스트에 스트링 값 저장 구문
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    card.Add(pattern[i] + numbers[j]);                 
                }
            }

            //foreach 이용 저장 잘 됐는지 확인
            //foreach (string cards in card)
            //{
            //    Console.WriteLine(cards);
            //}
            
            //1~52 중 랜덤 수 뽑은 것을 저장
            //pcCheckNumber = rand.Next(1, card.Count);
            //userCheckNumber = rand.Next(1, card.Count);

            List<string> userCard = new List<string>(); // 유저의 카드 5 개 받아오는
            List<string> pcCard = new List<string>(); // pc 카드 5개 받아오는

            //card 리스트의 랜덤 번호 인덱스의 값을 pc card에 추가
            //pcCard.Add(card[checkNumber1]);
            //pcCard.Add(card[checkNumber2]);
            //pcCard.Add(card[checkNumber3]);
            //pcCard.Add(card[checkNumber4]);
            //pcCard.Add(card[checkNumber5]);

            //pc와 user에 5번 반복하게 해서 랜덤값 추가해주기
            
            int count = 0;
            while(count < 5)  
            {
                count++;

                pcCheckNumber = rand.Next(1, card.Count);
              
                pcCard.Add(card[pcCheckNumber]);

                userCheckNumber = rand.Next(1, card.Count);
                userCard.Add(card[userCheckNumber]);
            }

            for (int i = 0; i < 5; i++)
            {
                
                pcCheckNumber = rand.Next(1, card.Count);
                userCheckNumber = rand.Next(1, card.Count);


                if (userCard[i] != userCard[i+1])
                {
                    userCard.Add(card[userCheckNumber]);
                }
                
               
                if (pcCard[i] != pcCard[i+1])
                {
                    pcCard.Add(card[pcCheckNumber]);
                }
                
            }


            #region 출력확인용
            Console.Write(pcCard[0]);
            Console.Write(pcCard[1]);
            Console.Write(pcCard[2]);
            Console.Write(pcCard[3]);
            Console.Write(pcCard[4]);


            Console.WriteLine("");

            Console.WriteLine("");
            Console.Write(userCard[0]);
            Console.Write(userCard[1]);
            Console.Write(userCard[2]);
            Console.Write(userCard[3]);
            Console.Write(userCard[4]);

            Console.WriteLine("");
            Console.WriteLine("");
            #endregion;

            

            










        }
    }
}
