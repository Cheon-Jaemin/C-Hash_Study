/* Console.ReadLine() 예시 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class _14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문자열을 입력받으시오");
            string input = Console.ReadLine();

            Console.WriteLine("input : " + input);

            //문자열을 정수로 변환하기
            int intinput = int.Parse(input);
            Console.WriteLine(intinput + 1);
        }
    }
}
