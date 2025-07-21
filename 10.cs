/* 인스턴스 메소드 (반환형이 있고 매개변수가 있는 메소드) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _10
    {
        class Test
        {
            public int Power(int x)
            {
                return (x * x);
            }
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine("정수 한개 입력하시오");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("결과 : {0}", test.Power(x));
        }
    }
}
