/* static 변수와 instance 변수의 비교 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class _3
    {
        class MyMath
        {
            public static double PI = 3.141592;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMath.PI);
        }
    }
}
