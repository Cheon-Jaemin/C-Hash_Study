/* 2025/ 07/ 21 (월) 아침퀴즈 4번 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine("{0} : 야옹", Name);
        }
    }

    internal class _24
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            cat1.Name = "키티";
            cat1.Color = "하얀색";
            cat2.Name = "네로";
            cat2.Color = "검은색";

            cat1.Meow();
            Console.WriteLine("{0} : {1}", cat1.Name, cat1.Color);
            cat2.Meow();
            Console.WriteLine("{0} : {1}", cat2.Name, cat2.Color);
        }
    }
}
