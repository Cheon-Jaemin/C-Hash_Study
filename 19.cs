/* 정렬 - 배열의 정렬 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class _19
    {
        class Fruit : IComparable
        {
            string name;
            int price;

            public Fruit(string name, int price)
            {
                this.name = name;
                this.price = price;
            }

            public int CompareTo(object obj)
            {
                Fruit fruit = (Fruit)obj;

                return this.price.CompareTo(fruit.price);
            }
            public override string ToString()
            {
                return string.Format("과일명 : {0} 가격 : {1}", this.name, this.price);
            }
        }

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Fruit("Apple", 100));
            list.Add(new Fruit("Banana", 50));
            list.Add(new Fruit("Kiwi", 500));
            list.Add(new Fruit("Cherry", 10));
            list.Add(new Fruit("Melon", 800));
            list.Add(new Fruit("Lemon", 200));

            list.Sort();
            foreach(Fruit fruit in list)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
