/* 호출한 곳으로 되돌아가는 예제(return뒤에 아무것도 x) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _14
    {
        static void printGugudan(int dan)
        {
            if(!(2 <= dan && dan <= 12)) //두 조건이 참이라면 !(NOT)에 의해 거짓이되어
            {                           // 반복문을 실행                
                return;
            }

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", dan, i, dan * i);
            }
            return; //반환 타입이 void. 생략 가능
        }

        static void Main(string[] args)
        {
            printGugudan(12);
        }
    }
}
