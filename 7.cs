/* object로 선언한 다양한 자료형 형태 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _7
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.1415_9265_3589_7932_3846_2643_3832_79m;
            object c = true;
            object d = "안녕하세요";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
