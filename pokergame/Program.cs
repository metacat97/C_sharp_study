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

            change changeAB = new change();
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
            //리스트 저장
            List<string> userCard = new List<string>(); // 유저의 카드 5 개 받아오는
            List<string> pcCard = new List<string>(); // pc 카드 5개 받아오는
            //pc와 user에 7번 반복하게 해서 랜덤값 추가해주기
            int count = 0;
            while (count < 7)
            {
                count++;
                pcCheckNumber = rand.Next(1, card.Count);
                pcCard.Add(card[pcCheckNumber]);

                userCheckNumber = rand.Next(1, card.Count);
                userCard.Add(card[userCheckNumber]);
            }
            //중복처리 
            for (int i =0; i<7; i++) 
            {
                for (int j = 0; j<7; j++)
                {
                    if (userCard[i] == userCard[j])
                    {
                        userCard.RemoveAt(j);
                        userCheckNumber = rand.Next(0, card.Count-1);
                        userCard.Add(card[userCheckNumber]);
                    }
                    if (pcCard[i] == pcCard[j])
                    {
                        pcCard.RemoveAt(j);
                        pcCard.Add(card[pcCheckNumber]);
                        pcCheckNumber = rand.Next(0, card.Count-1);
                    }
                }
            }

            #region 출력확인용
            Console.WriteLine("<---Pc Card--->");

            for (int i = 0; i < pcCard.Count; i++)
            {
                Console.SetCursorPosition(i*10, 1);
                Console.WriteLine("┌────────────────┐");
                Console.SetCursorPosition(i*10, 2);
                Console.WriteLine("│ {0}           │", pcCard[i]);
                Console.SetCursorPosition(i*10, 3);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 4);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 5);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 6);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 7);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 8);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 9);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 10);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 11);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 12);
                Console.WriteLine("│            {0}│", pcCard[i]);
                Console.SetCursorPosition(i*10, 13);
                Console.WriteLine("└────────────────┘");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("<---User Card--->");
            for (int i = 0; i < userCard.Count-2; i++)
            {
                Console.SetCursorPosition(i*10, 17);
                Console.WriteLine("┌────────────────┐");
                Console.SetCursorPosition(i*10, 18);
                Console.WriteLine("│ {0}           │", userCard[i]);
                Console.SetCursorPosition(i*10, 19);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 20);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 21);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 22);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 23);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 24);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 25);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 26);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 27);
                Console.WriteLine("│                │");
                Console.SetCursorPosition(i*10, 28);
                Console.WriteLine("│            {0}│", userCard[i]);
                Console.SetCursorPosition(i*10, 29);
                Console.WriteLine("└────────────────┘");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion;



            First:
            //5장중  교환할 카드 선택
            Console.WriteLine() ;
            Console.WriteLine("몇개의 카드를 바꾸시나요?");
            int inputInt = int.Parse(Console.ReadLine());
            if (inputInt == 1)
            {
                Console.WriteLine("1~5 번째 카드중 바꿀 카드의 번호를 입력해주세요.---->");
                int userNumber1 = int.Parse(Console.ReadLine());
                userCard.RemoveAt(userNumber1-1);
                Console.WriteLine();
                //새로 뽑은 유저 카드 출력
               // Console.WriteLine("<---After User Card--->");
                for (int i = 0; i < userCard.Count-1; i++)
                {
                    //Console.WriteLine("<---After User Card--->");
                    Console.SetCursorPosition(i*10, 17);
                    Console.WriteLine("┌────────────────┐");
                    Console.SetCursorPosition(i*10, 18);
                    Console.WriteLine("│ {0}           │", userCard[i]);
                    Console.SetCursorPosition(i*10, 19);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 20);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 21);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 22);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 23);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 24);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 25);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 26);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 27);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 28);
                    Console.WriteLine("│            {0}│", userCard[i]);
                    Console.SetCursorPosition(i*10, 29);
                    Console.WriteLine("└────────────────┘");
                }
            }
            else if (inputInt == 2)
            {
                Console.WriteLine("1~5 번째 카드중 바꿀 카드의 번호를 입력해주세요.---->");
                //함수
                changeAB.AddSub(ref userCard);
                //int userNumber1 = int.Parse(Console.ReadLine());
                //int userNumber2 = int.Parse(Console.ReadLine());
                ////선택한 숫자 삭제
                //userCard.RemoveAt(userNumber1-1);
                //userCard.RemoveAt(userNumber2-1);
                Console.WriteLine();
                //새로 뽑은 유저 카드 출력
                for (int i = 0; i < userCard.Count-2; i++)
                {
                    //Console.WriteLine("<---After User Card--->");
                    Console.SetCursorPosition(i*10, 17);
                    Console.WriteLine("┌────────────────┐");
                    Console.SetCursorPosition(i*10, 18);
                    Console.WriteLine("│ {0}           │", userCard[i]);
                    Console.SetCursorPosition(i*10, 19);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 20);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 21);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 22);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 23);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 24);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 25);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 26);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 27);
                    Console.WriteLine("│                │");
                    Console.SetCursorPosition(i*10, 28);
                    Console.WriteLine("│            {0}│", userCard[i]);
                    Console.SetCursorPosition(i*10, 29);
                    Console.WriteLine("└────────────────┘");
                }
            }
            else
            {
                Console.WriteLine("다시 입력해주세요.");
                goto First;
            }



        }
    }
}
