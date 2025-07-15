/* 열거형 형변환 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    enum Days { SUN = 1, MON, TUE, WED, THU, FRI, SAT};
    internal class _11
    {
        static void Main(string[] args)
        {
            int nValue = (int)Days.MON; //일반형 타입에 저장할 때
            Days day = Days.THU;        //열거형 변수에 열거형 값을 대입 
            Console.WriteLine("{0}, {1}", nValue, day);
        }
    }
}
