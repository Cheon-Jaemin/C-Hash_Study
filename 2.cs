/* 멀티 델리게이트 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class _2
    {
        delegate void TypeF(int a, int b); // 델리게이트 선언
                                           // 델리게이트가 참조할 수 있도록 같은 형태의 메서드 구현
        static void Plus(int x, int y) 
        { 
            Console.WriteLine(x + y); 
        }
        static void Minus(int x, int y)
        { 
            Console.WriteLine(x - y); 
        }
        static void Multiple(int x, int y) 
        { 
            Console.WriteLine(x * y); 
        }
        static void Main(string[] args)
        {
            TypeF delgateValue = Plus; // 델리게이트에 메서드 전달
            delgateValue += Minus; // 멀티 델리게이트 구성
            delgateValue += Multiple;

            delgateValue(20, 10); // 델리게이트를 통해 메서드 호출
        }
    }
}
