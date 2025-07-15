/* 구조체를 선언하여 각 과목의 점수를 저장하고
 합계와 평균을 구하는 코드를 작성하시오. 
구조체에 선얼할 멤버 - 국, 수 ,영, 합계, 평균 
Main메소드에서 구조체 변수를 선언하고 구조체 멤버를 호출하여
값을 입력받아 합계 및 평균을 계산하고 합계 및 평균을 출력 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    public struct Point
    {
        public int kor;
        public int eng;
        public int math;
        public int sum;
        public double mean;
    }

    internal class test1
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            Console.WriteLine("국어점수를 입력하세요 >");
            point.kor = int.Parse(Console.ReadLine());

            Console.WriteLine("수학점수를 입력하세요 >");
            point.math = int.Parse(Console.ReadLine());

            Console.WriteLine("영어점수를 입력하세요 >");
            point.eng = int.Parse(Console.ReadLine());

            point.sum = (point.kor + point.eng + point.math);
            point.mean = (point.sum / 3.0);

            Console.WriteLine("국어 : {0}, 영어 : {1}, 수학 : {2}", point.kor, point.eng, point.math);
            Console.WriteLine("합계 = {0}, 평균 = {1:f}", point.sum, point.mean);
        }
    }
}
