/* 문자열의 연산 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _9
    {
        static void Main(string[] args)
        {
            string str1 = "Hello_";
            string str2 = "World!";
            string str3 = str1 + str2;
            string str4 = "program" + "ming";

            Console.WriteLine("{0} {1}", str3, str4);
            Console.WriteLine(str3[4]); 
        }
    }
}
