/* Thread 멀티스레드 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace day8
{
    internal class _6
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);  // thread 생성, 매개변수는 스레드가 실행할 메소드

            t.Start();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("메인 스레드 : {0}", i + 1);
                Thread.Sleep(100);
            }
            Console.WriteLine("메인 스레드 종료");
        }

        private static void WriteY() 
        {
            for(int i = 0; i < 10; i++) //메인 스레드가 종료되어도 서브스레드가 10까지 센 뒤 프로그램 종료
            {
                Console.WriteLine("스레드 : {0}", i + 1);
                Thread.Sleep(100);
            }
            Console.WriteLine("서브 스레드 종료");
        }
    }
}
