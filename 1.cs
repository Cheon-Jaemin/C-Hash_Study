/* 짝수와 홀수를 if else문으로 구분하기 */

using System;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 입력");
            string input = Console.ReadLine();
            int a = int.Parse(input);   
            // 입력받은 문자열 정수형으로 변환하여 저장

            if (a % 2 == 0) // a를 2로 나눈 나머지가 0 이면 짝수
            {
                Console.WriteLine("짝수");
            }
            else // 아니면 홀수
            {
                Console.WriteLine("홀수");
            }
        }
    }
}
