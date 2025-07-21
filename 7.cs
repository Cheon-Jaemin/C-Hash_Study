/* 매개변수가 있는 생성자를 사용하여 값을 넣어 인스턴스 생성
 변수의 이름과 자료형은 본인이 스스로 선택 클래스 이름은 Member
변수의 초기값은 사용자로 부터 입력받아 사용 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _7
    {
        class Member
        {
            public string name;
            public int mineral;
            public int supply;
            public int HP;
            public int ATK;

            public Member()
            {
                name = "";
                mineral = 0;
                supply = 0;
                HP = 0;
                ATK = 0;
            }

            public Member(string name, int mineral, int supply, int HP, int ATK)
            {
                this.name = name;
                this.mineral = mineral;
                this.supply = supply;
                this.HP = HP;
                this.ATK = ATK;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력하시오");
            string name = Console.ReadLine();
            Console.WriteLine("미네랄을 입력하시오");
            int mineral = int.Parse(Console.ReadLine());
            Console.WriteLine("보급품을 입력하시오");
            int supply = int.Parse(Console.ReadLine());
            Console.WriteLine("HP를 입력하시오");
            int HP = int.Parse(Console.ReadLine());
            Console.WriteLine("공격력을 입력하시오");
            int ATK = int.Parse(Console.ReadLine());

            Member member = new Member(name, mineral, supply, HP, ATK);

            Console.WriteLine("Name : {0}", member.name);
            Console.WriteLine("Mineral : {0}", member.mineral);
            Console.WriteLine("Supply : {0}", member.supply);
            Console.WriteLine("HP : {0}", member.HP);
            Console.WriteLine("Attack : {0}", member.ATK);
        }
    } 
}
