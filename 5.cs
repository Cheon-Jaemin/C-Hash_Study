/* List의 Remove()메소드를 사용해서 요소 제거 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _5
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 52, 27, 43, 56 };

            list.Remove(52);    //요소 제거

            foreach(var item in list)
            {
                Console.WriteLine("Count {0} \t item : {1}", list.Count, item);
            }
        }
    }
}
