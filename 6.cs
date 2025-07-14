/* 멤버변수 bool형의 기본값과 지역변수 bool변수 값 초기화 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _6
    {
        static bool boolVar;    //클래스 멤버변수 초기화안하면 자동 false

        static void Main(string[] args)
        {
            bool localBoolVar = true;   // 지역변수는 자동초기화 안하기에 초기화해서 사용해야함
            Console.WriteLine("{0} {1}", boolVar, localBoolVar);
        }
    }
}
