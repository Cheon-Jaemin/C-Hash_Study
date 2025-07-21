/* 임의의 정수를 사용해서 다음과 같은 숫자 맞추기 코드를 만들어 보세요 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _8
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int temp = random.Next(1, 50);

            while (true)
            {
                Console.WriteLine("숫자를 입력하세요.");
                int read = int.Parse(Console.ReadLine());

                if (temp == read)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
                else if (temp > read)
                {
                    Console.WriteLine("{0}보다는 큰 숫자입니다.", read);
                }
                else
                {
                    Console.WriteLine("{0}보다는 작은 숫자입니다.", read);
                }
            }
        }
    }
}
