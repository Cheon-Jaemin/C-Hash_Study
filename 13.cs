/* 인덱서로 배열처럼 사용하는 제곱 클래스 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    class A
    {
        public int this[int i]
        {
            get { return i * i; }
            set
            {
                Console.WriteLine("{0}의 제곱", i);
            }
        }
    }
    internal class _13
    {
        static void Main(string[] args)
        {
            A square = new A();
            int count = 0;
            for (int i = 10; i <= 100; i = i + 10)
            {
                Console.WriteLine("클래스 호출 반환값 출력 {0} : {1}", count, square[i]);
                //square[]는 인덱서를 통해 계산을 함(get)

                Console.WriteLine(square[i] = square[i]);
                //앞쪽의 square[]는 계산된 결과값을 넣어줌(set)
                
                count++;
            }
        }
    }
}
