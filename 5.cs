/* 사용자로부터 정수 한 개를 입력 받아 
 * 그 숫자가 '음수', '양수', '0' 인지 판별하고
 짝수인지 홀수인지 구분하여 나타내시오 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _5
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("정수를 입력하시오");
            a = int.Parse(Console.ReadLine());

            if(a > 0)
            {
                Console.WriteLine("양수");  
            }
            else if (a < 0)
            {
                Console.WriteLine("음수");
            }
            else
            {
                Console.WriteLine("0");
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }
        }
    }
}
