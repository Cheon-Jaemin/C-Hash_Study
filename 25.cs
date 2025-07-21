/* 2025/ 07/ 21 (월) 아침퀴즈 6번 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class People
    {
        public static int cnt = 0;
        public int count2;
        public int finger;
        public string name;

        public People()
        {
            count2 = 0;
            name = " ";
            finger = 0;
        }

        public People(int finger, string name)
        {
            this.finger = finger;
            this.name = name;
            People.cnt = People.cnt + 1;
        }
    }

    internal class _25
    {
        static void Main(string[] args)
        {
            People people1 = new People(10, "홍길동");
            Console.WriteLine("{0} : {1} {2}", People.cnt, people1.name, people1.finger);
            
            People people2 = new People(9, "코난");
            Console.WriteLine("{0} : {1} {2}", People.cnt, people2.name, people2.finger);
            
            People people3 = new People(10, "김전일");
            Console.WriteLine("{0} : {1} {2}", People.cnt, people3.name, people3.finger);
            
            Console.WriteLine("{0}개 생성됨", People.cnt);
        }
    }
}
