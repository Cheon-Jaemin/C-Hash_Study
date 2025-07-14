/* 데이터 형변환(소수점 변화) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _19
    {
        static void Main(string[] args)
        {
            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0"));  
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("0.0000"));
            //문자열 자릿수 설정해주기 
        }
    }
}
