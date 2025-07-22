/* 피보나치 수로 재귀 메소드 만들기 n > 1일 때 자기 자신을 계속 사용 */

using System;

namespace day6
{
    class Fibonacci
    {
        public static long Get(int n)  //피보나치 수는 기하급수적으로 커지므로 long자료형을 사용
        {
            if (n < 0)  //종료 조건
            {
                return 0;
            }
            if (n == 1) //종료 조건
            {
                return 1;
            }

            return Get(n - 1) + Get(n - 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(2));
            Console.WriteLine(Fibonacci.Get(3));
            Console.WriteLine(Fibonacci.Get(4));
            Console.WriteLine(Fibonacci.Get(5));
        }
    }
}
