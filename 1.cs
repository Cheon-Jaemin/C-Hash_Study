/* 델리게이트 Delegate */

using System;

namespace day8
{
    internal class Program
    {
        delegate int TypeF(int a, int b); // 델리게이트 선언, 함수포인터 같은 역할
                                          // 델리게이트가 참조할 수 있도록 같은 형태의 메서드 구현
        static int Plus(int x, int y) 
        { 
            return x + y; 
        }
        static int Minus(int x, int y) 
        { 
            return x - y; 
        }
        static void Main(string[] args)
        {
            TypeF delgateValue = new TypeF(Plus);//델리게이트의 인스턴스를 만들때도 new연산자 필요(메서드 전달)
            int result = delgateValue(20, 10); // 델리게이트를 통해 메서드 호출
            Console.WriteLine(result);
            
            TypeF delgateValue2 = Minus; // 델리게이트에 메서드 전달, (1)메서드 이름을 사용한 초기화 방법
            int result2 = delgateValue2(20, 10); // 델리게이트를 통해
            Console.WriteLine(result2); // 메서드 호출
        }
    }
}
