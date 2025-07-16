/* C#에서 가능한 switch문의 문자열 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _6
    {
        static void Main(string[] args)
        {
            string str = "yes";

            switch(str)
            {
                case "no":
                    {
                        Console.WriteLine("no 입니다.");
                        break;
                    }
                case "yes":
                    {
                        Console.WriteLine("yes 입니다.");
                        break;
                    }
            }
        }
    }
}
