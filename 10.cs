/* 부모 생성자 호출을 명시적으로 지정할 때, base 사용 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{ 
    internal class _10
    {
        class Parent
        {
            public Parent() 
            {
                Console.WriteLine("부모 생성자");
            }
        }

        class Child : Parent
        {
            public Child() : base()
            {
                Console.WriteLine("자식 생성자");
            }
        }

        static void Main(string[] args)
        {
            Child childB = new Child();
        }
    }
}
