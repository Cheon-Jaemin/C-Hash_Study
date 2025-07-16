/* 복사 Clone() */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _24
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] cloneArr = (int[])arr1.Clone();
            //Clone()의 반환타입은 object형. int[]로 형변환(언박싱)

            cloneArr[2] = 30;

            foreach (var m in arr1)
            {
                Console.Write("{0} ", m);
            }
            Console.WriteLine();

            foreach (var m in cloneArr)
            {
                Console.Write("{0} ", m);
            }
            Console.WriteLine();

            string[] days = { "일", "월", "화", "수", "목", "금", "토" };
            string[] cloneDays = (string[])days.Clone();

            foreach(var m in cloneDays)
            {
                Console.Write("{0} ", m);
            }
        }
    }
}
