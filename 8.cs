/* 상위 클래스의 접근제한 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class A
    {
        private char a = 'A';
        protected char b = 'B';
        public char c = 'C';

        private void printA()
        {
            Console.WriteLine("private");
        }
        protected void printB()
        {
            Console.WriteLine("protected");
        }
        public void printC()
        {
            Console.WriteLine("public");
        }
    }

    class B : A
    {
        public void print()
        {
            Console.WriteLine("a : private는 호출 안됨, b : {0}, c : {1}", base.b, base.c);
            //printA(); //호출 불가능 private

            base.printB();
            base.printC();
        }
    }

    internal class _8
    {
        static void Main(string[] args)
        {
            B test = new B();
            //test.b = 'b'; // protected로 선언되어 있는 것은 클래스 내부, 즉 클래스 B까지만 접근 가능
            test.c = 'c';
            //test.printB();    // protected
            test.printC();
            test.print();   // print()를 통한 char b, printB(), printC() 호출
        }
    }
}
