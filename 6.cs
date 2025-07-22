/* 사용자로부터 2개의 정수를 입력받아 서로 값을 Swap하는 메소드를 호출하여
 * 입력받은 2개의 정수가 Swap되었는지 확인하기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class _6
    {
        static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개 입력");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Swap이 일어나기 전 a = {0}, b = {1}", x, y);

            Swap(ref x, ref y);
            Console.WriteLine("Swap이 일어난 후 a = {0}, b = {1}", x, y);
        }
    }
}
