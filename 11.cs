/* 클래스 메소드 (생성자를 사용하지 않고 바로 클래스를 통해 메소드를 사용) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class MyMath
    {
        public static int Abs(int input)
        {
            if(input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
    }
    internal class _11
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
        }
    }
}
