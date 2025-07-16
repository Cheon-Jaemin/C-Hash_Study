/* Length와 foreach 반복문을 사용한 배열 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _19
    {
        static void Main(string[] args)
        {
            int[] nArray = { 1, 2, 3, 4, 5 };
            int sum = 0;

            // 배열의 길이가 바뀔 때마다 수정 불필요
            for (int i = 0; i < nArray.Length; i++)
            {
                Console.Write("{0} ", nArray[i]);
                sum = (sum + nArray[i]);
            }
            Console.WriteLine(sum);

            // foreach사용, 간단한 코드의 경우 for문보다 간결
            sum = 0;
            foreach (int m in nArray)
            {
                Console.Write("{0} ", m);
                sum = (sum + m);
            }
            Console.WriteLine(sum);
        }
    }
}
