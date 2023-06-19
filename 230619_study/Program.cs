using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230619_study
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog mydog = new Dog();

            mydog.PrintAnotherThings();

            int number = 5;
            number.PlusAndPrint(5);            

        }
        static void Desc002()
        {
            Parent myParent = new Parent();
            Child myChild = new Child();

            //myParent.PrintInfos();
            //myChild.PrintInfos();   

            Parent tempParent = myChild; // 업캐스팅
            Child tempChild = (Child)tempParent; // 강제 형변환을 통해 다운 캐스팅 함

            tempParent.PrintInfos(); // 자식을 부모에 담은 경우
            tempChild.PrintInfos(); //강제형변환으로 담은 경우 위와 같다


            List<MonsterBase> monsterList = new List<MonsterBase>();
            Wolf mywolf = new Wolf();

            monsterList.Add(mywolf);

            foreach (MonsterBase monster_ in monsterList)
            {
                monster_.PrintInfos();
            }
        }
        static void Desc001()
        {
            int num = 20;
            char charvalue = 'a';
            string textStr = "Hello world";

            //오브젝트는 기본 자료형이다.
            object canSaveAll1 = num;
            object canSaveAll2 = charvalue;
            object canSaveAll3 = textStr;

            //var 와 object는 완전 다르다  (오브젝트는 타입이고 var는 추론하는 것이기에)
            //리플렉션이 일어나는 것인데 컴파일 타임에 타입을 추론한다.
            var canSabeAnything1 = num; //num을 위에서 선언했으니 추적가능
            var canSabeAnything2 = charvalue; // var는 object도 받을 수 있다
            var canSabeAnything3 = textStr;
            //안전을 위해 특정 하위 로직에서 사용할 수 있다

            //모든것을 담을 수 있지만 안에 든 것을 알 수 는 없다.
            int number2 = (int)canSaveAll1;  // 오브젝트 타입에 박싱을 해버렸기 때문에




            //그대로 잘 출력 된다.   
            Console.WriteLine(canSaveAll1); // 20
            Console.WriteLine(canSaveAll2); // a
            Console.WriteLine(canSaveAll3); // Hello world

            Console.WriteLine(number2);
        }


    }
}
