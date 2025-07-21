/* 클래스 메소드에서는 static이 붙은 클래스 변수만 사용할 수 있음. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _12
    {
        public static int instanceVariable = 10;
        // static이 존재하는 클래스 변수에만 접근이 가능 
        
        static void Main(string[] args)
        {
            Console.WriteLine(instanceVariable);
        }
    }
}
