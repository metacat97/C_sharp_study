using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230619_study
{
    public class Child : Parent
    {
        string strChild = default;

        public override void PrintInfos() 
        {
            //base.PrintInfos();//부모의 printinfos 를 쓰겠다는 base.  내껄 쓰겠다면 this 를 쓰면 된다.

            number = 10;
            strValue = "This is child";
            strChild = "Sentences of child added";

            Console.WriteLine("Parent class number : {0} , strValue : {1} strChild{2}",
                this.number, this.strValue, this.strChild);//변수는 지금 부모에게서 그대로 받아온 것이라서
                                                           // this 를 써서 내가 쓴 것을 쓰겠다는 것이다.
        }
    }
}
