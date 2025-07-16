/* 원하는 크기의 배열 생성과 배열의 초기화 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _20
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];  // 숫자 타입의 요소는 0으로 초기화
            string[] arr2 = new string[100];    //참조 타입의 요소는 null로 초기화
            bool[] arr3 = new bool[100];        //bool 타입의 요소는 false로 초기화
            
            Console.WriteLine(arr1[30]);    //초기화 되었는지 확인
            Console.WriteLine(arr2[30]);
            Console.WriteLine(arr3[30]);
        }
    }
}
