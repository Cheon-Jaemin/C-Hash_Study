/* 비트연산자 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class _18
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 10;

            Console.WriteLine("{0} & {1} : {2}", a, b, (a & b));
            Console.WriteLine("{0} | {1} : {2}", a, b, (a | b));
            Console.WriteLine("{0} ^ {1} : {2}", a, b, (a ^ b));

            int c = 255;
            Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, ~c);  
        }
    }
}
