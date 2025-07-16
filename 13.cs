/* foreach문 연습 ArrayList활용 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _13
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(); // ArrayList 클래스
            list.Add(1);
            list.Add(2);    // list = {1, 2, 3} 배열 만들어줌 
            list.Add(3);

            foreach(int nValue in list)
            {
                Console.WriteLine(nValue);
            }
        }
    }
}
