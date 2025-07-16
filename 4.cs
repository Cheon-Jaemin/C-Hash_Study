/* 컴퓨터의 현재 시간이 11시 이전이면 아침먹을 시간입니다.
 * 15시보다 작으면 점심먹을 시간입니다.
 그 이후면 저녁먹을 시간입니다 출력되게 하기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _4
    {
        static void Main(string[] args)
        {
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else if(DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다.");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다.");   
            }
        }
    }
}
