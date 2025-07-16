/* 가변배열 연습 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _22
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[3] { 1, 2, 3 };
            array[1] = new int[2] { 4, 5 };

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
