/* 같은 이름으로 멤버를 만들어 부모의 멤버 숨기기(new 키워드) */

using System;

namespace day7
{
    class Parent
    {
        public int var = 2783;
        public virtual void Method()
        {
            Console.WriteLine("부모");
        }
    }

    class Child : Parent
    {
        public string var = "hiding";
        public new void Method()    //오버라이딩 할 때 자식클래스에서 new키워드를 사용하게 되면 자식클래스의 메소드가 가려지게 됨
        {
            Console.WriteLine("자식");
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Parent child = new Child(); //부모로 위장한 자식
            Console.WriteLine(child.var);
            child.Method();
        }
    }
}
