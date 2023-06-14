using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _230614_study
{
    public class print001           //클래스의 접근 수준이 public 
    {
        //클래스 내부에 변수 함수 만들 수 있다 .
        // 멤버 변수 = 곧 필드이다.
        // 클래스 내부에 있는 함수를 멤버 함수 => 메서드

        //private 는 캡슐화다
        public static string staticMessage = default;
        private string message = default;




        public void PrintMessage(string localMessage)   // 메서드의 접근 수준도 public 
        {
            message = localMessage;
            Console.WriteLine("이런걸 출력할 것 -> {0}", message);

        }
        
        
        


    }
}
