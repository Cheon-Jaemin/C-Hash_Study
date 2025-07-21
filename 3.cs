/* List 클래스 (정수) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _3
    {
        static void Main(string[] args)
        {
            //리스트 선언 뒤에 배열처럼 요소를 입력해도 됨 (우선순위 높음)
            List<int> list = new List<int>() { 2, 3, 4, 5, 6 }; //변수 선언

            //리스트에 요소 추가
            list.Add(52);
            list.Add(222);
            list.Add(444);
            list.Add(543);
            list.Add(66);
            list.Add(9999);
            list.Add(777);

            //반복을 통해 출력
            foreach (var item in list)
            {
                Console.WriteLine("Count {0} \t item : {1}", list.Count, item);
            }
        }
    }
}
