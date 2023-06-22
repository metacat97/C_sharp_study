using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocketmon
{
    public class Quest
    {

        public int questStart(ref int questState ,ref int questConditions, int y_Text_Position, int x_Text_Position)
        {

            Console.SetCursorPosition(y_Text_Position+1, x_Text_Position);
            Console.WriteLine("┌────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(y_Text_Position + 1, x_Text_Position+1);
            Console.WriteLine("│                                                            │");
            Console.SetCursorPosition(y_Text_Position + 1, x_Text_Position+2);
            Console.WriteLine("│                                                            │");
            Console.SetCursorPosition(y_Text_Position + 1, x_Text_Position+3);
            Console.WriteLine("│                                                            │");
            Console.SetCursorPosition(y_Text_Position + 1, x_Text_Position +4);
            Console.WriteLine("│                                                            │");
            Console.SetCursorPosition(y_Text_Position + 1, x_Text_Position+5);
            Console.WriteLine("│                                                            │");
            Console.SetCursorPosition(y_Text_Position + 1, x_Text_Position +6);
            Console.WriteLine("└────────────────────────────────────────────────────────────┘");

            if (questState == 0)
            {
                Console.SetCursorPosition(y_Text_Position+3, x_Text_Position+2);
                Console.WriteLine("누가 나 좀 도와줬으면 좋겠는데 ...        ");
                Console.ReadKey();
                Console.SetCursorPosition(y_Text_Position+3, x_Text_Position+2);
                Console.WriteLine("도와주시겠습니까? < y / n >              ");
                ConsoleKeyInfo choiceInput = Console.ReadKey();
                if (choiceInput.Key == ConsoleKey.Y)
                {
                    Console.SetCursorPosition(y_Text_Position+3, x_Text_Position+2);
                    Console.WriteLine("정말 고맙네                            ");
                    Console.ReadKey();
                    questState += 1;
                }
                else if (choiceInput.Key == ConsoleKey.N)
                {
                    Console.SetCursorPosition(y_Text_Position+3, x_Text_Position+2);
                    Console.WriteLine("너무하군.....                             ");
                    Console.ReadKey();
                }
            }
            else if(questState == 1) 
            {
                if (questConditions >= 2)
                {
                    Console.SetCursorPosition(y_Text_Position+3, x_Text_Position+2);
                    Console.WriteLine("오 왔는가?");
                    Console.ReadKey();
                    Console.SetCursorPosition(y_Text_Position+3, x_Text_Position+2);
                    Console.WriteLine("수고했네");
                    Console.ReadKey();
                    Console.SetCursorPosition(y_Text_Position+3, x_Text_Position+2);
                    Console.WriteLine("보상은 다음에 받게나");
                    Console.ReadKey();
                    questState = 0;
                    questConditions = 0;
                }
                else if (questConditions < 2)
                {
                    Console.SetCursorPosition(y_Text_Position+3, x_Text_Position+1);
                    Console.WriteLine("수가 적군 다시 구해오게나");
                    Console.ReadKey();
                }
            }
            return questConditions;
        }

    }
}
