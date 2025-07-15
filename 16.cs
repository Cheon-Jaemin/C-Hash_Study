/* 나머지 연산자의 부호 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class _16
    {
        static void Main(string[] args)
        {
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3);

            // 나머지 연산자의 부호는 왼쪽 피연산자의 부호를 따름
            // 따라서 오른쪽 피연산자의 부호는 연산에 상관없음
            // 보통 연산을 할 때 마이너스 부호는 사용할 일이 거의 없으므로 참고할 것
        }
    }
}
