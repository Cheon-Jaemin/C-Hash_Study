/* 여러 클래스에서 Global이라는 클래스의 정적 필드에 접근하는 코드 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class _4
    {
        class Global
        {
            public static int Count = 0;
        }
        class ClassA
        {
            public ClassA()
            { 
                Global.Count++;
            }
        }
        class ClassB
        {
            public ClassB()
            {
                Global.Count++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Global.Count : {0}", Global.Count);

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();
            Console.WriteLine("Global.Count : {0}", Global.Count);
        }
    }
}
