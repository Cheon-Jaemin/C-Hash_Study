/* 분할클래스 만들기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    partial class MyClass   // 분할1
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
    partial class MyClass   // 분할2
    {
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
        public void Method4()
        {
            Console.WriteLine("Method4");
        }
    }

    internal class _3
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Method1();
            myClass.Method2();
            myClass.Method3();
            myClass.Method4();
        }
    }
}
