/* 예외 처리 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class _8
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)  //범위를 벗어난 인덱스 예외처리
            {
                Console.WriteLine("배열의 인덱스 예외가 발생");
                Console.WriteLine("{0}", e.Message);    //e.StackTrace 예외발생 위치를 알려줌
            }

            Console.WriteLine("프로그램이 종료됩니다.");
        }
    }
}
