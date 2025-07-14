/* 암시적 형식의 다양한 예시 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _15
    {
        static void Main(string[] args)
        {
            var a = 20; //Var은 개별 선언만 가능 
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.14;
            var c = "Hello, World!";
            var d = new int[] { 10, 20, 30 };

            Console.WriteLine($"{b} / {c} / {d[0]} , {d[1]} , {d[2]}");
        }
    }
}
