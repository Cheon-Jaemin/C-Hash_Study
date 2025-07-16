/* 사용자로부터 태어난 년도를 입력받아 그 해의 띠를 출력하시오
입력 받은 년도를 12로 나눈 나머지가 
0,1,2,3,4,5,6,7,8,9,10,11 일때
원숭이 닭 개 돼지 쥐 소 호랑이 토끼 용 뱀 말 양띠 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class test1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("태어난 년도를 입력하세요");
            int year = int.Parse(Console.ReadLine());

            if (year % 12 == 0)
            {
                Console.WriteLine("원숭이띠");
            }
            else if (year % 12 == 1)
            {
                Console.WriteLine("닭띠");
            }
            else if (year % 12 == 2)
            {
                Console.WriteLine("개띠");
            }
            else if (year % 12 == 3)
            {
                Console.WriteLine("돼지띠");
            }
            else if (year % 12 == 4)
            {
                Console.WriteLine("쥐띠");
            }
            else if (year % 12 == 5)
            {
                Console.WriteLine("소띠");
            }
            else if (year % 12 == 6)
            {
                Console.WriteLine("호랑이띠");
            }
            else if (year % 12 == 7)
            {
                Console.WriteLine("토끼띠");
            }
            else if (year % 12 == 8)
            {
                Console.WriteLine("용띠");
            }
            else if (year % 12 == 9)
            {
                Console.WriteLine("뱀띠");
            }
            else if (year % 12 == 10)
            {
                Console.WriteLine("말띠");
            }
            else if (year % 12 == 11)
            {
                Console.WriteLine("양띠");
            }
        }
    }
}
