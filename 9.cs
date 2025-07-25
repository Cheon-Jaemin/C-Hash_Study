/* 스레드에 2개 이상의 매개변수 전달(클래스를 만들어야 함) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace day8
{
    internal class _9
    {
        class ThreadParam //값을 하나가 아니라 두 개 이상의 값을 전달할 때는 여러 값을 담고 있는 클래스를 따로 정의해서
                          //클래스 인스턴스를 전달하면 됨
        {
            public int value1;
            public int value2;
        }
        static void Main(string[] args)
        {
            ThreadParam param = new ThreadParam();
            param.value1 = 10;
            param.value2 = 20;

            Thread t = new Thread(WriteY);
            
            t.Start(param);
            t.Join();
            Console.WriteLine("메인 스레드 종료");
        }
        private static void WriteY(object obj)
        {
            ThreadParam param2 = (ThreadParam)obj;
            Console.WriteLine("{0}, {1}", param2.value1, param2.value2);
            Thread.Sleep(100);
            Console.WriteLine("서브 스레드 종료");
        }
    }
}
