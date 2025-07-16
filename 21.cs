/* 중첩의 반복문을 사용하여 2차원 배열의 형식 연습 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _21
    {   
        static void Main(string[] args)
        {
            int[,] nArray1 = new int[2, 2];
            nArray1[0, 0] = 1;
            nArray1[0, 1] = 2;
            nArray1[1, 0] = 3;
            nArray1[1, 1] = 4;

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(nArray1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] nArray2 = { { 1, 2 }, { 3, 4 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(nArray2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            string[,,] strArray = 
            { 
                { { "ab", "cd" }, { "ef", "gh" } },
                { { "ij", "kl" }, { "mn", "op" } } 
            };
            
            for (int i = 0; i < 2; i++) //면
            {
                for (int j = 0; j < 2; j++) //행
                {
                    for (int k = 0; k < 2; k++) //열
                    {
                        Console.Write(strArray[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
