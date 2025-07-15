/* null 조건부 연산자(?.) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Foo
    {
        public int number;
    }
    internal class _20
    {
        static void Main(string[] args)
        {
            Foo foo = null;
            int? bar;   // nullable형 null값이 필요할 때 사용

            bar = foo ?. number;
            Console.WriteLine(bar);
        }
    }
}
