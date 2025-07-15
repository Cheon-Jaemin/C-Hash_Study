/* string에서 + 문자열 연결 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class _17
    {
        static void Main(string[] args)
        {
            string str = "3" + ".14";
            Console.WriteLine(str);
            Console.WriteLine(+5);
            Console.WriteLine(5 + 5);
            Console.WriteLine(5 + .5);
            Console.WriteLine("5" + "5");
            Console.WriteLine(5.01f + "5");
            Console.WriteLine("5" + 3.14f);
            Console.WriteLine(5 + 5 + 5 + "문자열");
            str = 1 + "test" + 3.14f + "abcd";
            Console.WriteLine(str);
        }
    }
}
