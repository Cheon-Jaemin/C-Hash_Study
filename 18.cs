/* 명명된 매개변수 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _18
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine("Name : {0}, Phone : {1}", name, phone);
        }

        static void Main(string[] args)
        {
            PrintProfile(name : "박포댕", phone : "010-1234-5678");
            PrintProfile(phone: "010-6666-7777" , name: "홀란두");
            PrintProfile("Sonny", "777-7777-7777");
            PrintProfile("도쿠", phone: "786-345-321");
        }
    }
}
