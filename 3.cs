/* 멀티 델리게이트 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    delegate void ThereIsFire(string location); //델리게이트 선언, 클래스 외부에 선언할 수 있음

    class Firestation
    {
        public static void Call119(string location)
        {
            Console.WriteLine("소방서죠? 불이 났어요! 주소는 {0}", location);   // 첫번째 호출됨
        }
        public static void ShotOut(string location)
        {
            Console.WriteLine("피하세요! {0}에 불이 났어요!", location);   
        }
        public static void Escape(string location)
        {
            Console.WriteLine("{0}에서 나갑시다!", location);
        }
    }
    internal class _3
    {
        static void Main(string[] args)
        {
            ThereIsFire fire = new ThereIsFire(Firestation.Call119);    //델리게이트 생성 Call119 호출
            fire += Firestation.ShotOut;
            fire += Firestation.Escape;

            fire("우리집");    //델리게이트를 통한 메소드 호출, 동시 호출
        }
    }
}
