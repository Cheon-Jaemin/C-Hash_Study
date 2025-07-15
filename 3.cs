/* 구조체의 const, static */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    public struct Mystruct
    {
        public const float PI = 3.14159f;
        public static int age = 27;
        public int val;
        //public int val = 10; //초기화 불가 오류발생 

        public Mystruct(int val)
        {
            this.val = val;
        }
    }
    internal class _3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}, {1}", Mystruct.PI, Mystruct.age);
            //const, static 으로 되어 있는 멤버는 구조체명으로만 접근 가능

            Mystruct s; //구조체 변수 선언
            s.val = 10;
            Console.WriteLine(s.val);
            // Console.WriteLine(s.PI); // 인스턴스 에선 일반 필드에만 접근가능 
        }
    }
}
