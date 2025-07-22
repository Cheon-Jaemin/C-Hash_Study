/* 상속과 다형성 Dog, Cat 클래스 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Animal
    {
        public int Age
        {
            get; set;
        }
        public string Color
        {
            get; set;
        }

        public Animal()
        {
            this.Age = 0;
        }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
        public virtual void Bark() { }
        public virtual void Meow() { }
    }

    class Dog : Animal  //Animal 클래스로부터 상속을 받은 Dog와 Cat 클래스
    {
        public override void Bark()
        {
            base.Color = "노란색";
            Console.WriteLine("Dog클래스 호출");
            Console.WriteLine("멍멍 짓습니다.");
        }
    }

    class Cat : Animal  //Animal 클래스로부터 상속을 받은 Dog와 Cat 클래스 
    {
        public override void Meow()
        {
            base.Color = "하얀색";
            Console.WriteLine("Cat클래스 호출");
            Console.WriteLine("냥냥 웁니다.");
        }
    }

    internal class _7
    {
        static void Main(string[] args)
        {
            List<Animal> Animal = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Cat(), new Dog(), new Cat(), new Dog(), new Cat()
            };

            foreach (var item in Animal)
            {
                item.Eat(); //부모로 위장한 자식은 부모의 멤버만 사용할 수 있음
                item.Sleep();
                //if (item is Dog)
                //{
                //    ((Dog)item).Bark();
                //}
                //if (item is Cat)
                //{
                //    ((Cat)item).Meow();  //자식 Cat에 있는 멤버는 사용할 수 없음.
                //}
                var dog = item as Dog;
                if(dog != null)
                {
                    dog.Bark();
                }

                var cat = item as Cat;
                if(cat != null)
                {  
                    cat.Meow(); 
                }
                Console.WriteLine();
            }

            //Dog dog = new Dog();
            //dog.Bark();
            //dog.Eat();  //부모클래스의 메소드 호출
            //dog.Sleep();
            //dog.Age++;
            //Console.WriteLine("강아지의 나이는 {0}살", dog.Age);
            //Console.WriteLine("강아지의 색은 {0}", dog.Color);
            //Console.WriteLine();

            //Cat cat = new Cat();
            //cat.Meow();
            //cat.Eat();  //부모클래스의 메소드 호출
            //cat.Sleep();
            //cat.Age++;
            //Console.WriteLine("고양이의 나이는 {0}살", cat.Age);
            //Console.WriteLine("고양이의 색은 {0}", cat.Color);
        }
    }
}
