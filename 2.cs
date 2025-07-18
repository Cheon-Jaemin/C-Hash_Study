/* 감자와 고구마 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class _2
    {
        class Product
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            public Product(string name, int price)
            {
                Product.counter = counter + 1;
                this.id = counter;
                this.name = name;
                this.price = price;
            }

            ~Product()
            {
                Console.WriteLine("소멸자의 호출");
            }
        }
        static void Main(string[] args)
        {
            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);
            Product productC = new Product("양파", 2500);
            Product productD = new Product("대파", 4000);
            
            Console.WriteLine("{0} : {1} {2}원", productA.id, productA.name, productA.price);
            Console.WriteLine("{0} : {1} {2}원", productB.id, productB.name, productB.price);
            Console.WriteLine("{0} : {1} {2}원", productC.id, productC.name, productC.price);
            Console.WriteLine("{0} : {1} {2}원", productD.id, productD.name, productD.price);
            Console.WriteLine("{0}개 생성되었습니다.", Product.counter);
        }
    }
}
