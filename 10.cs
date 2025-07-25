/* 스레드 - 폴링 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace day8
{
    internal class _10
    {
        static bool myFlag = false;
        static void Main(string[] args)
        {
            Thread t = new Thread(Func);
            
            t.Start();  //메인스레드는 서브스레드를 시작해주고 3까지 출력해준 후 flag를 true로 만들어 줌

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1);
                Thread.Sleep(100);
            }
            myFlag = true;
            Console.WriteLine("메인스레드 종료");
        }

        private static void Func()  //서브스레드 만들어줌 
        {
            while (true) // 서브스레드에서 돌아갈 메소드를 무한루프화 시키고 조건이 만족됐는지 체크
            {
                if (myFlag)
                {
                    Console.WriteLine("폴링 성공");
                    Console.WriteLine("서브 스레드 종료");
                    break;
                }
                Thread.Sleep(100);
            }
        }
    }
}
