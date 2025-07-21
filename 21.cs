/* 값복사와 참조복사
 참조 복사 - 2번째 방식 (ref키워드 사용) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _21
    {
        static void Swap(ref int input)
        {
            input = 20;
        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Swap이 일어나기 전 = {0}", a);
            Swap(ref a);
            Console.WriteLine("Swap이 일어난 후 = {0}", a);
        }
    }
}
