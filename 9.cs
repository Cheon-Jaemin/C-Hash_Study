/* base 키워드의 사용 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Parent
    {
        protected string name = "부모";
    }

    class Child : Parent    //파생 클래스 선언
    {
        public string name = "자식";  //자식클래스의 생성자 호출(부모클래스의 생성자 호출)
        public Child()
        {
            Console.WriteLine("base.name = {0}", base.name);
            Console.WriteLine("this.name = {0}", this.name);
        }
    }
    internal class _9
    {
        static void Main(string[] args)
        {
            Child childObj = new Child();   //자식클래스의 객체 생성(자식클래스의 생성자 호출)
        }
    }
}
