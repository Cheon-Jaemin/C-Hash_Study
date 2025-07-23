/* 컬렉션 - 정렬 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class _18
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "김건모", "김된모", "강아지", "황희찬", "최다니엘"};
            
            Console.WriteLine("정렬해서 출력");
            Array.Sort(arr1);
            foreach (string str in arr1)
            {
                Console.WriteLine(str + ",");
            }
            Console.WriteLine();

            Array.Reverse(arr1);
            Console.WriteLine("역방향 출력");
            foreach (string str in arr1)
            {
                Console.WriteLine(str + ",");
            }
        }
    }
}
