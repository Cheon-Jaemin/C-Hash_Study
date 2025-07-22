/* four클래스 만들고 Quadrant4 클래스 메소드 만들기
 반환형이 있고 매개변수가 있는 메소드 만드시오 
메인에서 사용자로부터 좌표를 입력 받아서 좌표가 속하는 사분면 반환 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Four
    {
        public static int Quadrant4(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if(x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                Console.WriteLine("사분면 위에 존재하지 않습니다.");
                return 0;
            }
        }
    }

    internal class _5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x축을 입력하세요.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("y축을 입력하세요.");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}사분면 입니다.", Four.Quadrant4(x, y));
        }
    }
}
