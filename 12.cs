/* 참조 형식 배열의 복사가 일어난 뒤 배열의 요소값 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class _12
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int[] reArr; //참조형 배열 변수
            reArr = arr; //C언어와 달리 객체의 메모리 주소가 복사됨, 객체의 복사 가능
            reArr[1] = 20; //reArr 인덱스 1번 값 20으로 변경
            
            // 배열 arr의 값이 변경됨
            Console.WriteLine("arr[0] = {0}, arr1[1] = {1}, arr1[2] = {2}", arr[0], arr[1], arr[2]);
        }
    }
}
