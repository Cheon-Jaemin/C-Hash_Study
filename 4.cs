/* 람다식 */

using System;
using System.Collections.Generic;   //제네릭 컬렉션(List<T> 등)을 사용하기 위해 필요
using System.Linq;  //LINQ(Language Integrated Query) 메서드를 사용하기 위해 필요

using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class _4
    {
        static void Main(string[] args)
        {
            // 정수형 리스트(List<int>)를 생성하고 초기화
            // 이 리스트는 1부터 6까지의 정수로 구성
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            // LINQ의 Where 메소드를 사용하여 짝수만 필터링
            // n => n % 2 == 0 은 람다식으로, n을 매개변수로 각 요소 n이 2로 나누어 떨어지는지 확인
            //조건을 만족하는 요소만 새로운 시퀀스에 포함
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            //콘솔에 텍스트를 출력
            Console.WriteLine("짝수 목록 : ");

            //필터링된 짝수 리스트를 반복하면서 각 값을 출력
            foreach(var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
