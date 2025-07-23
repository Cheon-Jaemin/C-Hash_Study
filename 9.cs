/* 예외 던지기 throw */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class _9
    {
        static void DoSomething()
        {
            Random random = new Random();
            int num = random.Next(0, 100);

            if(num < 80)
            {
                Console.WriteLine("현재 온도는 {0}입니다.", num);
            }
            else
            {
                throw new Exception($"위험! 온도가 높습니다. : {num}");
            }
        }
        
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    DoSomething();
                    System.Threading.Thread.Sleep(1000);    //1초 지연
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("시스템을 종료합니다.");
            }
        }
    }
}
