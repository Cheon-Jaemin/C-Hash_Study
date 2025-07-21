/* 메소드를 구성하여 표현 (반환형은 없고 매개변수가 있는 타입) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _9
    {
        public static void Plus(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("intput : {0}, {1}, result : {2}", a, b, result);
        }

        static void Main(string[] args)
        {
            Plus(3, 4);
            Plus(5, 6);
            Plus(7, 8);
        }
    }
}
