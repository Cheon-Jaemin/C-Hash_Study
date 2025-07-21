/* 선택적 매개변수 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _19
    {
        static void PrintProfile(string name = "이름없음", string phone = "")
        {
            Console.WriteLine("Name : {0}, Phone : {1}", name, phone);
        }

        static void Main(string[] args)
        {
            PrintProfile("태연");
            PrintProfile("윤아", "010-123-456");
            PrintProfile(name : "유리");
            PrintProfile(phone : "010-780-7897");
        }
    }
}
