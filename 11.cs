/* 매개변수가 있는 부모생성자 메소드를 호출하고 싶을 때 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{

    class Parent
    {
        public Parent()
        {
            Console.WriteLine("1_Parent()");
        }
        public Parent(int param)
        {
            Console.WriteLine("{0} : {1}", "2_Parent", param);
        }
        public Parent(string param)
        {
            Console.WriteLine("{0} : {1}", "3_Parent", param);
        }
    }

    class Child : Parent
    {
        public Child() : base()
        {
            Console.WriteLine("1_Child() : base()");
        }
        public Child(int a) : base(a) //Parent(int param) 부모 생성자를 호출함
        {
            Console.WriteLine("{0} : {1}", "2_Child(int a) -> base" ,a);
        }
        public Child(string input) : base(input)    //Parent(string param) 부모 생성자를 호출함 
        {
            Console.WriteLine("{0} : {1}", "3_Child(string input) -> base", input);
        }
    }
    internal class _11
    {
        static void Main(string[] args) 
        {
            Child childB = new Child(); //자식클래스의 객체 생성
            Child childC = new Child(10);
            Child childD = new Child("string");
        }
    }
}
