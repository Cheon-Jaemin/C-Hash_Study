/* 나비넥타이 만들기 별 뿌리기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class test4
    {
        static void Main(string[] args)
        {
            int line = 5;
           
            for (int i = line - 1; i >= 1; i--) //위쪽
            {
                
                for (int j = 1; j <= line - i; j++) 
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= line - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= (2 * line - 1); i++) // 가운데 나비 매듭
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 1; i <= line - 1; i++) //아래쪽
            {
                for (int j = 1; j <= line - i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= line - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
