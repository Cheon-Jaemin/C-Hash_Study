/* 인터페이스 - 로그를 출력하기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    interface ILog  // C#에서는 인터페이스명 첫 글자에 I를 붙이는 것이 규칙
    {
        void WriteLog(string message);
    }
    class ConsoleLog : ILog
    {
        public void WriteLog(string message)    //WriteLog 메소드를 반드시 구현해야함
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    internal class _5
    {
        static void Main(string[] args)
        {
            ILog log = new ConsoleLog();    //인터페이스는 인스턴스는 생성 못하지만 참조는 만들 수 있음
            //Ilog log = new Ilog();    //불가능
            log.WriteLog("Hello World");
        }
    }
}
