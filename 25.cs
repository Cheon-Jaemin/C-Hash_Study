/* 기타 메소드 및 속성 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _25
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            foreach (var score in scores)
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine();

            Array.Sort(scores);                                                                 //Array클래스의 Sort()메서드를 사용해 배열을 정렬
            foreach (var score in scores)
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine();
            
            Console.WriteLine("Number of dimensions : {0}", scores.Rank);                       //scores배열의 차원을 Rank프로퍼티가 반환
            
            Console.WriteLine("Binary Search : 81 is at {0}", Array.BinarySearch(scores, 81));  //정렬후scores에서 81의 위치 탐색
            Console.WriteLine("Linear Search: 90 is at {0}", Array.IndexOf(scores, 90));        //scores에서 90의 인덱스값을 반환
            
            Console.WriteLine("Old length of scores: {0}", scores.GetLength(0));                //다차원 배열에서 지정한 배열의 길이를 반환
            Array.Resize<int>(ref scores, 10);                                                  //ref 참조형 변수로 사용하는 키워드, 배열의 크기를 Resize에 의해 재정의
            Console.WriteLine("New length of scores : {0}", scores.Length);                     //scores의 길이가 5에서 10으로 바뀜
        }
    }
}
