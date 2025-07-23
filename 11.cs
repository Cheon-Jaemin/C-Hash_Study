/* 프로퍼티(속성) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    class MyClass
    {
        private static string name;
        public static string MyName    // 접근제한자 데이터타입 프로퍼티명
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 5)
                {
                    Console.WriteLine("이름은 5자 이상 넘을 수 없습니다.");
                }
                else
                {
                    name = value;   //value 키워드는 선언한 적 없지만 C#컴파일러는 
                }                   //set 접근자의 암묵적 매개변수로 간주함
            }
        }
        public static int Age 
        {
            get; set;
        }
    }
    internal class _11
    {
        static void Main(string[] args)
        {
            //MyClass student = new MyClass();
            
            MyClass.MyName = "CJM";
            MyClass.Age = 13;
            Console.WriteLine($"저의 이름은 {MyClass.MyName}, 나이는 {MyClass.Age}입니다.");
        }
    }
}
