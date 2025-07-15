/* 구조체 멤버들을 같은 구조체에 대입하면 값 복사가 이뤄짐 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    public struct Mystruct
    {
        public int age;
        public string name;
    }

    internal class _7
    {
        static void Main(string[] args)
        {
            Mystruct testStruct1, testStruct2;
            testStruct2.age = 27;
            testStruct2.name = "struct";
            Console.WriteLine("복사할 구조체 : age = {0}, name = {1}", testStruct2.age, testStruct2.name);

            testStruct1 = testStruct2;  //구조체 복사를 통한 초기화
            Console.WriteLine("복사 된 구조체 : age = {0}, name = {1}", testStruct1.age, testStruct1.name);
        }
    }
}
