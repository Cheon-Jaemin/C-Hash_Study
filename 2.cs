/* 현재 컴퓨터의 시간을 불러와서 오전 오후 구분하기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _2
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now.Year);
            //Console.WriteLine(DateTime.Now.Month);
            //Console.WriteLine(DateTime.Now.Day);
            //Console.WriteLine(DateTime.Now.Hour);
            //Console.WriteLine(DateTime.Now.Minute);
            //Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToString());

            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            else
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
