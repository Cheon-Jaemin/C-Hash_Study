/* 구조체의 생성자 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    public struct Mystruct
    {
        public int val;
        public Mystruct()
        {
            this.val = 10;
        }
    }
    internal class _2
    {
        static void Main(string[] args)
        {
            Mystruct s = new Mystruct();

            Console.WriteLine(s.val);   
        }
    }
}

