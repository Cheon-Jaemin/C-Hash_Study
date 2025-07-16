/* 피라미드 별 뿌리기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class test3
    {
        static void Main(string[] args)
        {
            int line = 8;

            for (int i = 1; i <= line; i++)     //줄바꿈
            {
                for (int j = 1; j <= line - i; j++)     //공백넣기
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (i * 2 - 1); j++)  //별뿌리기
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
