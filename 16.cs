/* 오버로딩 Abs()메소드 만들기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class MyMath
    {
        public int Abs(int input)
        {
            if(input < 0)
            {
                return -input;
            }
            else 
            {
                return input;
            }
        }
        public double Abs(double input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
        public decimal Abs(decimal input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
    }
    internal class _16
    {
        static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("정수 입력");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("정수형 Abs()호출 : {0}", myMath.Abs(x));
                Console.WriteLine();

                Console.WriteLine("실수 입력");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("실수형 Abs()호출 : {0}", myMath.Abs(y));
                Console.WriteLine();

                Console.WriteLine("실수(decimal) 입력");
                decimal z = decimal.Parse(Console.ReadLine());
                Console.WriteLine("실수(decimal)형 Abs()호출 : {0}", myMath.Abs(z));
                Console.WriteLine();
            }
        }
    }
}
