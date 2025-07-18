/* 2025 07 18 (금) 아침퀴즈 3번 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class _7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("다이아몬드의 높이를 입력하시오.");
            int line = int.Parse(Console.ReadLine());
            int i, j, k;

            for (i = 1; i <= (line / 2) + 1; i++)
            {
                for(j = i; j <= (line / 2); j++)
                {
                    Console.Write(" ");
                }
                for(k = 1; k <= (2 * i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (i = (line / 2); i >= 1; i--)
            {
                for (j = i; j <= (line / 2); j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (2 * i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
            }
        }
    }
}
