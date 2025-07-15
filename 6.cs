/* 생성자의 매개변수를 이용한 출력 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    public struct Mystruct
    {
        public int age;
        public float num;
        public bool isReady;
        public Mystruct (int inAge, float innum, bool inisReady)
        {
            this.age = inAge;
            this.num = innum;
            this.isReady = inisReady;
        }
    }

    internal class _6
    {
        static void Main(string[] args)
        {
            Mystruct test;
            test.age = 12;
            Console.WriteLine(test.age);

            //생성자 호출로 기본값으로 초기화
            Mystruct test2 = new Mystruct();
            Console.WriteLine("{0} {1} {2}", test2.age, test2.num, test2.isReady);

            //생성자 호출로 매개변수값 전달해서 구조체 멤버 초기화
            Mystruct test3 = new Mystruct(13, 40, true);
            Console.WriteLine("생성자를 통해 매개변수 값 전달 : {0} {1} {2}", test3.age, test3.num, test3.isReady);
        }
    }
}
