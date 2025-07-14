/* nullable형을 선언하고 판독 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _16
    {
        static void Main(string[] args)
        {
            int? num1 = null;

            Console.WriteLine(num1.HasValue); //num1 에 값이 없어서 False
            if(num1 != null)
            {
                Console.WriteLine(num1.Value); //num1에 값이 없어서 조건에 거짓이 되어 출력 x
            }

            num1 = 150;
            Console.WriteLine(num1.HasValue); //num1에 값이 150이 생겨서 True
            Console.WriteLine(num1.Value);    // 150출력   
        }
    }
}
