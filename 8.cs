/* 문자열을 배열에 인덱스에 접근해서 사용하기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _8
    {
        static void Main(string[] args)
        {
            string str1 = "안녕하세요.";
            string str2 = "모블 교육센터입니다.";

            Console.WriteLine("{0} \n", str1);
            Console.WriteLine("{0} \n", str2);
            Console.WriteLine("{0}", str2[1]);

            string str3 = "c : \\temp\\test.text";
            Console.WriteLine("{0}", str3);

            string str4 = "c : \temp\test.txt"; //이스케이프 문자 \t 사용 
            Console.WriteLine("{0}", str4);
        }
    }
}
