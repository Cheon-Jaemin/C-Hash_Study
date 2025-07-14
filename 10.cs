/* 문자열의 문자 개수를 Length 로 확인 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _10
    {
        static void Main(string[] args)
        {
            string str1 = "Hello_World!";
            Console.WriteLine("문자 개수 : {0}", str1.Length);
            // 중괄호안에 순서를 넣어주고 뒤에 넣어주면 됨
            Console.WriteLine($"문자 개수 : {str1.Length}");
            // $를 쓰면 중괄호안에 바로 값을 넣어주면 됨
        }
    }
}
