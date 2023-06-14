using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _230614_study
{
    public static class print002           //클래스의 접근 수준이 public 
    {
       // 이 cs 파일은 static 를 이해하기 위해서 작성한 파일입니다.
        private static string message = default;

        public static void PrintMessage(string localMessage)   // 메서드의 접근 수준도 public 
        {
            message = localMessage;
            Console.WriteLine("이런걸 출력할 것 -> {0}", message);

        }
        
    }
}
