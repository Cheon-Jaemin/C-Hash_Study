/* 단항 연산자 증감연산자 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class _15
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);

            int b = 10;
            Console.WriteLine(b--);
            Console.WriteLine(--b);
        }
    }
}
