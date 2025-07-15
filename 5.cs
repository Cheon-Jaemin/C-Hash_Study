/* 구조체 멤버를 입력받아 출력하기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    public struct MyStruct
    {
        public int age;
        public string testA = null;
        public string testB = null;
        public MyStruct(int inAge)
        {
            this.age = inAge;
        }
    }

    internal class _5
    {
        static void Main(string[] args)
        {
            MyStruct s1; // 사용방법 1
            Console.WriteLine("age 입력");
            s1.age = int.Parse(Console.ReadLine()); // 문자열 > int형 변환
            Console.WriteLine("구조체 멤버 age = {0}", s1.age);

            MyStruct s2 = new MyStruct();
            Console.WriteLine("문자열 멤버 입력");
            s2.testA = Console.ReadLine();
            s2.testB = Console.ReadLine();
            Console.WriteLine("구조체 문자열 멤버1 : {0}, 구조체 문자열 멤버2 : {1}", s2.testA, s2.testB);
        }
    }
}
