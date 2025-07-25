/* 람다식 문자열 리스트에서 길이가 5 초과인 첫번째 문자열 출력 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class _5
    {
        static void Main(string[] args)
        {
            //문자열 리스트 생성
            List<string> words = new List<string> { "apple", "kiwi", "grape", "watermelon", "banana" };

            //람다식을 메소드 인자로 사용하여 조건에 맞는 첫 번째 단어를 찾음
            //find 메소드는 길이가 5보다 큰 첫 번째 문자열 (요소)를 반환
            string result = words.Find(word => word.Length > 5);

            //결과 출력
            Console.WriteLine("길이가 5보다 큰 첫 단어 : {0}", result);    
        }
    }
}
