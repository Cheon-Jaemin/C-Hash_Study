/* 튜플의 선언 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class _9
    {
        static void Main(string[] args)
        {
            (int, int) tuple1 = (110, 50);
            Console.WriteLine($"{tuple1.Item1}, {tuple1.Item2}");

            (int Max, int Min) tuple2 = (110, 50);
            Console.WriteLine($"{tuple2.Max}, {tuple2.Min}");

            var tuple3 = (Max: 100, Min: 50);
            Console.WriteLine($"{tuple3.Max}, {tuple3.Min}");

            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");  
        }
    }
}
