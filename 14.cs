/* string배열을 선언하고 foreach를 통해 배열 요소 출력 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _14
    {
        static void Main(string[] args)
        {
            //배열의 요소값 생성
            string[] intArray = { "사과", "자두", "복숭아", "딸기", "귤" };

            Console.WriteLine("foreach와 var를 통해 출력하기");
            // 반복을 통해 요소값 출력
            foreach (var str in intArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}
