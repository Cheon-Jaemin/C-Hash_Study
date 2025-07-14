/* 숫자와 문자열 덧셈 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _21
    {
        static void Main(string[] args)
        {
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");

            //숫자와 문자열을 +연산자를 사용하면 문자열 연결로 적용됨 
            //문자열과 문자열도 마찬가지임
        }
    }
}
