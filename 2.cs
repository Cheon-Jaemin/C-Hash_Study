/* Random 클래스(라이브러리 함수) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _2
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            Console.WriteLine("정수 생성");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(10, 100));
            }
            Console.WriteLine();

            Console.WriteLine("실수 생성");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.NextDouble() * 10);
            }
            Console.WriteLine();

            Console.WriteLine("실수 반올림 표현");
            for (int i = 0; i < 5; i++)
            {
                double r1 = Math.Round(random.NextDouble(), 2); //소수 둘째자리까지 반올림하여 표시 
                Console.WriteLine(r1);
            }
        }
    }
}
