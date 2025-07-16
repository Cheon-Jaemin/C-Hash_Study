/* foreach문을 이용하여 배열 요소값을 출력 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _12
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            foreach(var nValue in arr) //nValue는 읽기 전용
            {
                Console.WriteLine(nValue);  // foreach문을 사용할 때는 식별자와
            }                               // 식별자의 데이터형을 함께 괄호안에 선언
        }
    }
}
