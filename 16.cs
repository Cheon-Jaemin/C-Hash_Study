/* 컬렉션 Stack */

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class _16
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while(stack.Count > 0)
            {
                Console.Write("{0} ",stack.Pop());  // LIFO
            }
        }
    }
}
