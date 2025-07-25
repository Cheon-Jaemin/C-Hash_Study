/* Thread.Join 해당 스레드가 종료될때 까지 다른 스레드 대기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace day8
{
    internal class _7
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY); // thread 생성, 매개변수는 스레드가 실행할 메서드
            t.Start(); //스레드 실행, 스레드가 메모리에 적재되는 시점, CLR은 스레드를 실제로 생성하여 WriteY()메서드를 호출
            
            t.Join(); //스레드를 블록(blocked)시키므로 해당 시간동안 블록(블락)된 스레드는 CPU자원을 소모하지 않음, 해당 스레드가 끝날때 까지 대기
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("메인 스레드 : " + (i + 1));
                Thread.Sleep(100);
            }
            Console.WriteLine("메인 스레드 종료");
        }
        private static void WriteY()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("스레드 : " + (i + 1));
                Thread.Sleep(100);
            }
            Console.WriteLine("서브 스레드 종료");
        }
    }
}
