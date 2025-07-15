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
        public int age1;
        //public int val = 10; //초기화 불가 오류발생 

        public Mystruct(int val)
        {
            this.val = val;
            this.age1 = 0;
        }
    }
    internal class _3
    {
        static void Main(string[] args)
        {
            Mystruct s; // 사용방법 1 : 생성자 없이 구조체 변수 선언
            s.age1 = 12;    //구조체 변수를 선언하고 초기화 후 사용
            Console.WriteLine(s.age1);

            //사용방법 2 : 매개변수가 없는 생성자를 통한 초기화
            //매개변수가 숫자형식이므로 자동0으로 초기화
            Mystruct s2 = new Mystruct();
            Console.WriteLine(s2.age1);

            //사용방법 3 : 매개변수가 있는 생성자로 인스턴스 생성
            //매개변수 값을 전달해서 초기화후 출력
            Mystruct s3 = new Mystruct(15);
            Console.WriteLine("{0}", s3.val);
        }
    }
}
