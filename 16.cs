/* 2025/ 07/ 22 (화) 아침퀴즈 3번 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class _16
    {
        static int[] CA1(int a)
        {
            Random random = new Random();
            int[] arr1 = new int[a];

            for(int i = 0; i < a; i++)
            {
                arr1[i] = random.Next(0, 10);
            }

            return arr1;
        }

        static int[,] CA2(int a, int b)
        {
            Random random = new Random();
            int[,] arr2 = new int[a, b];
            
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    arr2[i, j] = random.Next(0, 10);
                }
            }
            return arr2;
        }

        static void Main(string[] args)
        {
            int[] nArray;
            int[,] nArray2;

            nArray = CA1(6);
            nArray2 = CA2(3, 5);

            Console.WriteLine("nArray의 1차원 배열 출력");
            for(int i = 0; i < nArray.Length; i++)
            {
                Console.Write(nArray[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("nArray2의 2차원 배열 출력");
            for(int i = 0; i < nArray2.GetLength(0); i++)
            {
                for(int j = 0; j < nArray2.GetLength(1); j++)
                {
                    Console.Write(nArray2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
