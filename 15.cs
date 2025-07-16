/* 별 직각삼각형 만들기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _15
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for(j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
