/* 초기화 Clear() */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _23
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            Array.Clear(arr1, 2, 3);    //arr1의 인덱스 2번부터 3길이 만큼 0

            foreach(int m in arr1)
            {
                Console.Write(m);
            }
            Console.WriteLine();

            //arr1의 인덱스 0번부터 총 길이만큼 0으로 초기화
            Array.Clear(arr1, 0, arr1.Length);

            foreach(int m in arr1)
            {
                Console.Write(m);
            }
            Console.WriteLine();
        }
    }
}
