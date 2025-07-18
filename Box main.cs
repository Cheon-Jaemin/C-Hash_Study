/* Box Class */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Box_main
    {
        static void Main(string[] args)
        {
            Box Box = new Box();

            Box.Width = 100;
            Box.Height = 50;
            Console.WriteLine("Box의 면적");
            Console.WriteLine("{0}", Box.area);

            Console.WriteLine();
            Box.Width = -2;
            Box.Height = -4;

            Box Box2 = new Box(20, 40);
            Console.WriteLine();
            Console.WriteLine("Box2의 면적");
            Console.WriteLine("{0}", Box2.area);
        }
    }
}
