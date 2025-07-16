/* 사용자로부터 x, y 좌표를 입력 받아 좌표가 속하는 사분면을 
 화면에 출력하는 프로그램을 작성하시오 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class test2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x축을 입력하세요 : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("y축을 입력하세요 : ");
            int y = int.Parse(Console.ReadLine());

            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("1사분면 입니다.");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine("2사분면 입니다.");
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine("3사분면 입니다.");
            }
            else if ((x > 0) && (y < 0))
            {
                Console.WriteLine("4사분면 입니다.");
            }
            else if ((x == 0) && (y == 0))
            {
                Console.WriteLine("원점입니다.");
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");  
            }
        }
    }
}
