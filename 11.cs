/* do while문 무조건 한번 실행되는 것 활용하기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _11
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine("A) i : {0}", i--);
            } while (i > 0);
            do
            {
                Console.WriteLine("B) i : {0}", i--);
            } while (i > 0);
        }
    }
}
