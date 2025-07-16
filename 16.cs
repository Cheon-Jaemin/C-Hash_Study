/* break를 사용하여 실행의 흐름 벗어나기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _16
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("계속할까요? (예 / 아니요) > ");
                string answer = Console.ReadLine();

                if(answer == "아니요")
                {
                    break;  //가장 가까운 반복문 while을 빠져나간다.
                }   //  }밖이 break문 벗어나는 곳
            }
        }
    }
}
