/* 오버라이딩하면 클래스형을 어떻게 변환해도 자식에서 다시 정의한 메소드 호출 가능 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Dog //부모
    {
        public virtual void Bark()  //부모 메서드에 virtual 키워드 적용
        {                           //가상 메서드 : virtual 키워드로 부모 클래스에 정의

            Console.WriteLine("멍멍");
        }
    }

    class Pudle : Dog //자식
    {
        public override void Bark() //자식의 메서드에 override를 적용
        {                           //재정의 메서드 : override키워드로 자식 클래스의 메서드 재정의
            Console.WriteLine("왈왈");
        }
    }
    internal class _12
    {
        static void Main(string[] args)
        {
            Pudle pd = new Pudle(); // 자식
            pd.Bark();  // override된 Bark() 호출

            Dog dog1 = new Dog();   //부모
            dog1.Bark();    //부모의 Bark() 호출

            Dog dog2 = new Pudle(); //자식이 부모로 위장
            dog2.Bark();    //자식의 Bark() 호출
        }
    }
}
