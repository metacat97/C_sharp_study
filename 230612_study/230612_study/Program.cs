using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _230612_study
{
    public class Program
    {
        static void Main(string[] args)
        {

            SecretCode game = new SecretCode();
            game.thinkNumber();
        }

        static void work001()
        {
            //- 몬스터 이름, HP, MP , damage, defence, 몬스터 타입
            // 위에 저으이된 값을 출력하는 함수를 클래스 내부에 구현할 것 .
            Orc moborc = new Orc();
            moborc.Initilize("오크", 150, 40, 20, 10, "물");
            moborc.Print_MonsterInfo();

            Troll mobtrool = new Troll();
            mobtrool.Initilize("트롤", 100, 30, 20, 10, "대지");
            mobtrool.Print_MonsterInfo();
        }


        static void Desc002()
        {
            Dog myDog = new Dog();

            Console.WriteLine("우리집 강아지 이름은 {0} 이고, 다리 갯수는 {1}개 이다.",
             myDog.dogName, myDog.legCount);
            myDog.Print_DogDescription001();
            Dog.Print_DogDescription002();
            Console.WriteLine();

            Cat myCat = new Cat(4, "야옹이", "검정색");
            myCat.Print_MyCat();
            myCat.catName = "새로운 야옹이";
            myCat.Print_MyCat();
        }
        static void Desc001()
        {
            //call by value

            string[] str = new string[2] { "Hello", "World" };
            //CallFunc001(str);
            //CallFunc002("Hello", " world", "+", "Hello","world");
            //CallFunc003(ref str);

            string[] resultStr;
            CallFunc004(str, out resultStr);
            foreach (string result_ in resultStr)
            {
                Console.Write("{0}", result_);

            }
            Console.WriteLine();
            //call by reference


        }

        //! 첫 번째 방법은 매개 변수를 call by value 방식으로 넘기는 방법
        static void CallFunc001(string[] str)
        {
            foreach(string strElement in str)
            {
                Console.Write("{0}", strElement);
            }    
            Console.WriteLine();
        }   //callFunc001()

        //! 두번째 방법은 매개 변수를 call by value 방식으로 넘기는건 독같음 그런데 넘겨줄 매개변수를 배열의 요소 형태로 여러개 넘길 수 있다 .
        static void CallFunc002 (params string[] str)
        {
            foreach (string strElement in str)
            {
                Console.Write("{0}", strElement);

            }
            Console.WriteLine();


        }

        // 세 번째 방법은 매개 변수를 ㅊ미ㅣ ㅠㅛ ㄱㄷㄹㄷㄱ둧ㄷ 방식으로 넘기는 방법 
        static void CallFunc003(ref string[] str)
        {
            foreach (string strElement in str)
            {
                Console.Write("{0}", strElement);

            }
            Console.WriteLine();
        }


        // 네 번째 방법도 매개변수를 Call by reference 방식으로 넘기는 방법
        // 매개 변수를ㄹ 동해서  갓 허브로 넘긴다 .
        static void CallFunc004(string[] str, out string[] outStr)
        {
            string[] resultString = new string[str.Length + 1];
            for(int i = 0; i<str.Length; i++)
            {
                resultString[i] = str[i];
            }
            resultString[str.Length] = "!";
            outStr = resultString;
        }   

    }
}
