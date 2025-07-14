/* 형변환시 주의사항 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _17
    {
        static void Main(string[] args)
        {
            float f1 = 68.7512f;
            Console.WriteLine("float : {0}", f1);

            double d1 = (double)f1;
            Console.WriteLine("double : {0} \n", d1);   
            //작은 타입에서 큰 타입으로 변환시 정밀도 손상 
            
            double d2 = 68.7512;
            Console.WriteLine("double : {0}", d2);
            
            float f2 = (float)d2;
            Console.WriteLine("float : {0}", f2);
        }
    }
}
