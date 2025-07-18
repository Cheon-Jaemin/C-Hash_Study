/* 클래스 예제 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class Cat
    {
        public string name;     //이름 - 데이터 (속성)
        public string color;    //색깔 - 데이터 (속성)

        public Cat()
        {
            name = "";
            color = "";
        }

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void meow() // 메소드 (기능)
        {
            Console.WriteLine("{0} : 야옹", name);
        }
    }
    internal class Cat_main
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();  //Cat의 인스턴스 생성
            kitty.name = "키티";
            kitty.color = "하얀색";
            kitty.meow();
            Console.WriteLine("{0} : {1}", kitty.name, kitty.color);

            Console.WriteLine();
            Cat nero = new Cat();   //Cat의 2번째 인스턴스 생성
            nero.name = "네로";
            nero.color = "검은색";
            nero.meow();
            Console.WriteLine("{0} : {1}", nero.name, nero.color);

            Console.WriteLine() ;
            Cat navi = new Cat("나비", "갈색"); //Cat의 3번째 인스턴스 생성 
            navi.meow();
            Console.WriteLine("{0} : {1}", navi.name, navi.color);
        }
    }
}
