/* is, as연산자 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Animal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Animal 
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Animal 
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }
    internal class _13
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            Animal animal2 = new Cat();

            Dog dog;
            if (animal is Dog)
            {
                dog = (Dog) animal;
                dog.Bark();
            }

            Cat cat = animal2 as Cat;
            if (cat != null)
            {
                cat.Meow();
            }

            Cat cat2 = animal as Cat;
            if(cat2 != null)
            {
                cat2.Meow();
            }
            else
            {
                Console.WriteLine("cat2 is null");
            }
        }
    }
}
