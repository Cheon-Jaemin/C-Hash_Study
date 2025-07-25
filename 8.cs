/* 스레드에 매개변수 전달 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace day8
{
    internal class _8
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);
            
            t.Start(15); //스레드 호출시 매개변수 전달 방식
                         //스레드를 생성할 때 넣는 것이 아니라 start키워드의 매개변수에 넣어주어야 함, Thread t = new Thread(WriteY(7)) -> X(안됨)
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("메인 스레드 : " + (i + 1));
                Thread.Sleep(100);
            }
            Console.WriteLine("메인 스레드 종료");
        }
        private static void WriteY(object obj)
        {
            int num = (int)obj; //object로 받아서 형변환하여 사용
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("스레드 : " + (i + 1));
                Thread.Sleep(100);
            }
            Console.WriteLine("서브 스레드 종료");
        }    
    }
}
