/* int 자료형의 배열을 만들고 배열의 요소에 접근하는 코드 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _18
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 273, 32, 65, 103 };
            //배열 요소값 생성

            //요소값 출력
            Console.WriteLine("요소값 변경 전");
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);

            //배열의 요소값 변경
            intArray[0] = 0;
            Console.WriteLine();

            Console.WriteLine("요소값 변경 후");
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);

            //배열의 길이 출력
            Console.WriteLine();
            Console.WriteLine("배열의 길이");
            Console.WriteLine(intArray.Length);
        }
    }
}
