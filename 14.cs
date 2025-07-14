/* Var형 변수를 사용한 실수 타입에 대한 출력문의 제어 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _14
    {
        static void Main(string[] args)
        {
            var value1 = 3.14f;
            float value2 = 10.0f;
            float sum = (value1 + value2);

            Console.WriteLine("{0:f3} / {1:f5} / {2:f} / {3:f1} / {4:f3}", value1, value2, value2, value2, sum);
        }
    }
}
