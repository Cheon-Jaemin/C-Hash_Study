/* string 클래스가 제공하는 다양한 메소드2 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ToLower() : '{0}'", "ABC".ToLower());
            Console.WriteLine("ToUpper() : '{0}'", "ABC".ToUpper());

            Console.WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
            Console.WriteLine("Remove() : '{0}'", "I Don't Love You".Remove(2, 6));
            // 2번째 인덱스부터 6개 문자 삭제

            Console.WriteLine("Trim() : '{0}'", " No Spaces ".Trim());  // 앞뒤 공백 삭제
            Console.WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());    //앞 공백 삭제
            Console.WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());    //뒤 공백 삭제
        }
    }
}
