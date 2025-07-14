/* 문자열을 숫자로, 숫자를 문자열로 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _18
    {
        static void Main(string[] args)
        {
            int value1 = 127;
            string str1 = value1.ToString();    //Tostring으로 숫자를 문자열로 변환
            Console.WriteLine("value1의 값이 문자열로 바꼈는지 확인 = {0}", str1 + 1);
            // 문자열의 합인 1271 출력 

            int value2 = Convert.ToInt32(str1); // 문자 "127"을 정수로 변환 
            Console.WriteLine("str1의 값이 정수로 바꼈는지 확인 = {0}", value2 + 1);
            //정수의 합 128 출력 

            string str2 = "3.14";
            float value3 = float.Parse(str2);   //Parse로 문자열을 숫자로 변환
            Console.WriteLine("str2의 값이 실수로 바꼈는지 확인 = {0}", value3 + 1);
            //실수의 합 4.14 출력 
        }
    }
}
