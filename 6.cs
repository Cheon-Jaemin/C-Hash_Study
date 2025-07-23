/* IComparable 인터페이스(비교할 때 사용하는 규약) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class _6
    {
        class Interface
        {
            class Product : IComparable
            {
                public string Name { get; set; }
                public int Price { get; set; }

                public int CompareTo(object obj)
                {
                    return this.Name.CompareTo((obj as Product).Name);
                    //obj를 product로 형변환하기
                }

                public override string ToString()
                {
                    return Name + " : " + Price + "원";
                }
            }
            static void Main(string[] args)
            {
                List<Product> list = new List<Product>()
                {
                    new Product() { Name = "마우스패드", Price = 1500 },
                    new Product() { Name = "마우스", Price = 14000 },
                    new Product() { Name = "키보드", Price = 40000 },
                    new Product() { Name = "웹캠", Price = 35000 },
                    new Product() { Name = "Mic", Price = 1900 },
                    new Product() { Name = "Usb", Price = 5000 },
                    new Product() { Name = "리모컨", Price = 6000 },
                };
                list.Sort();

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
