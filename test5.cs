/* 사용자로부터 다이아몬드 높이 입력받아 별을 이용 출력 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class test5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("다이아몬드의 높이를 입력하시오");
            int line = int.Parse(Console.ReadLine());
   
            for (int i = 1; i <= line / 2 + 1; i++)
            {
                for (int j = i; j <= line / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = line / 2; i >= 1; i--)
            {
                for (int j = i; j <= line / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();  
            }
        }
    }
}
