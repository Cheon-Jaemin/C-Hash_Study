/* 출력전용 매개변수 키워드 : out
 결과값을 2개이상 반환하고 싶을 때 사용하는 키워드, 참조에 의한 반환 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _23
    {
        public static void DivideOut(int a, int b, out int c, out int d)
        {
            c = a / b;
            d= a % b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("두개의 정수 입력");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c, d;
            DivideOut(a, b, out c, out d);
            Console.WriteLine("몫 : {0}, 나머지 : {1}", c, d);
        }
    }
}
