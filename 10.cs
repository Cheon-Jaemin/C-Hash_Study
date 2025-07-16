/* 키 입력에 따른 switch문 사용한 분기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("콘솔키를 입력하시오");
            ConsoleKeyInfo info = Console.ReadKey();

            switch(info.Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        Console.WriteLine(" ^ 위로 이동");
                        break;
                    }
                case ConsoleKey.RightArrow:
                    {
                        Console.WriteLine(" > 오른쪽으로 이동");
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        Console.WriteLine(" v 아래로 이동");
                        break;
                    }
                case ConsoleKey.LeftArrow:
                    {
                        Console.WriteLine(" < 왼쪽으로 이동");
                        break;
                    }
            }
        }
    }
}
