/* null 병합 연산자 (??) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class _21
    {
        static void Main(string[] args)
        {
            int? x = null;  //nullable 형식 null 저장 가능
            int y = x ?? -1;    //y는 nullable형식이 아님
                                // 변수 y에 null값이 대입되면 에러 발생 
            Console.WriteLine(y);

            x = 10;
            y = x ?? -1;
            Console.WriteLine(y);
        }
    }
}
