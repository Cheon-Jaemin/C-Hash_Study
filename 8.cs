/* 구조체는 값 형식, 클래스는 참조 형식 예제 */

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
    }
    class Myclass
    {
        public int age;
    }

    internal class _8
    {
        static void Main(string[] args)
        {
            Mystruct test1 = new Mystruct(); //구조체의 생성자 선언
            test1.age = 12;

            Mystruct test2 = test1; // 값을 복사, 깊은 복사
            test2.age = 24;         // test1.age값을 유지

            Console.WriteLine("{0}, {1}", test1.age, test2.age);

            Myclass test3 = new Myclass(); //클래스의 인스턴스 선언
            test3.age = 12;

            Myclass test4 = test3;  // 참조변수의 주소를 복사, 얕은 복사
            test4.age = 24;         // test3, test4는 같은 객체,
                                    // 둘다 값 변경(포인터개념)
            Console.WriteLine("{0}, {1}", test3.age, test4.age);
        }
    }
}
