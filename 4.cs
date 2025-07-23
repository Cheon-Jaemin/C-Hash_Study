/* 인터페이스와 추상클래스의 상속을 통한 실습 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    interface IFightable // 공격기능이 있는 마린으로만 인터페이스를 선언한 뒤 ctrl+. 단축키를 누르면 메뉴가 보임(뒷장)
    {
        void attack();
    }

    abstract class Unit // 유닛의 공통된 상위 속성을 가진 부모 클래스(추상클래스)
    {
        public abstract void move(int x, int y);    // 마린클래스와 드롭쉽클래스의 움직임이
        void stop() { }                             // 달라 하위 클래스에서 구현
    }

    class Marine : Unit, IFightable // 추상 클래스와 인터페이스 상속, Marine은 Ifightable인터페이스가 정한 규약에
                                    //따라야 함
    {
        public override void move(int x, int y) //부모클래스로부터 오버라이드(부모 메서드 재정의)
        {
            Console.WriteLine("Marine Move [x : {0}, y : {1}]", x, y);
        }
        public void attack()    //attack()메서드, 인터페이스의 멤버에 대한 무조건적인 오라버라이딩으로 메서드
                                //구현

        {
            Console.WriteLine("Marine이 공격합니다.");
        }
        public void stimPack()
        {
            Console.WriteLine("스팀팩을 분사합니다.");
        }
    }

    class Dropship : Unit
    {
        public override void move(int x, int y)
        {
            Console.WriteLine("Dropship Move [x : {0}, y : {1}]", x, y);
        }
        public void load()
        {
            Console.WriteLine("수송기가 착륙했습니다.");
        }
    }
    internal class _4
    {
        static void Main(string[] args)
        {
            Marine marine1 = new Marine();
            //Ifightable marine = new Marine(); //인스턴스는 생성하지 못하지만 참조는 가능
            marine1.move(300, 300);
            marine1.attack();
            marine1.stimPack();
            
            Dropship dropship1 = new Dropship();
            dropship1.move(200, 200);
            dropship1.load();
        }
    }
}
