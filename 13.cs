/* ConsoleKeyInfo 속성의 예제 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class _13
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                //매개변수로 true를 넣으면 입력된 문자가 보이지 않는다.
                keyInfo = Console.ReadKey();

                //입력받은 키값은 소문자가 입력되어도 대문자로 인식
                if (keyInfo.Key == ConsoleKey.A)
                {
                    Console.WriteLine();
                    Console.WriteLine("A가 눌렸습니다.");
                }

                // 입력받은 문자의 대소문자 구분
                if (keyInfo.KeyChar == 'c')
                {
                    Console.WriteLine();
                    Console.WriteLine("c가 눌렸습니다.");
                }
            } while (keyInfo.Key != ConsoleKey.Escape); //Esc가 눌리면 빠져나감
        }
    }
}
