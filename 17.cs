/* continue문 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _17
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;   //가장 가까운 반복문 끝으로 간다.
                }

                Console.WriteLine("{0} : 홀수", i);
            }   //   }안으로 continue문이 건너뛴다.
        }
    }
}
