/* 조건문 응용 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("입력 : ");
            string line = Console.ReadLine();

            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요...!");
            }
            else
            {
                Console.WriteLine("^^!");
            }
        }
    }
}
