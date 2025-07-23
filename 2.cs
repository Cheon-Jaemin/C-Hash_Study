/* 추상클래스의 역할 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    public abstract class Animal
    {
        public abstract void Sound();   //공통사항
    }

    public class Dog : Animal 
    {
        public override void Sound()
        {
            Console.WriteLine("왈왈");
        }
    }
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("야옹");
        }
    }

    internal class _2
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            //Animal dog = new Animal();  //인스턴스 생성불가
            dog.Sound();
            Animal cat = new Cat();
            cat.Sound();
        }
    }
}
