/* 배열을 매개변수로 사용한 경우 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _13
    {
        static void TransArray(string[] args)
        {
            string[] hanDays = { "월 ", "화 ", "수 ", "목 ", "금 ", "토 " };
            
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = hanDays[i];   //배열 매개변수를 주소로 받음으로써
            }                           // engDays의 값이 변경 됨.
        }

        static void Main(string[] args)
        {
            string[] engDays = { "Mon ", "Tue ", "Wed ", "Thu ", "Fri ", "Sat " };
            TransArray(engDays);    //배열은 참조형으로 값이 아닌 주소를 전달
            foreach(string str in engDays)
            {
                Console.Write(str); 
                // return 받지 않아도 값이 변경됨 (call by reference)
            }
        }
    }
}
