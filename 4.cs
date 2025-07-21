/* List 클래스 (문자열) 
 리스트의 요소값을 주어진 범위 안에서 추출하기 (GetRange) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _4
    {
        static void Main(string[] args)
        {
            List<string> rivers = new List<string>(new string[]
            {
                "signals",
                "math",
                "express",
                "electro",
                "photonics"
            });

            List<string> range = rivers.GetRange(0, 3); 
            // GetRange(인덱스번호, 추출하고싶은 개수)

            foreach (string river in range) 
            {
                Console.WriteLine(river);
            }
        }
    }
}
