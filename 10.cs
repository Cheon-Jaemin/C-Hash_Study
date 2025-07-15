/* 사용자 지정형 - 열거형 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    enum DialogResult1 { YES, NO, CANCEL}
    enum DialogResult3 { YES = 10, NO, CANCEL, CONFIRM = 20, OK }

    internal class _10
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult1.YES);
            DialogResult1 result = DialogResult1.YES;
            Console.WriteLine(result == DialogResult1.YES);

            Console.WriteLine((int)DialogResult3.YES);
            Console.WriteLine((int)DialogResult3.NO);
            Console.WriteLine((int)DialogResult3.CANCEL);
            Console.WriteLine((int)DialogResult3.CONFIRM);
            Console.WriteLine((int)DialogResult3.OK);
        }
    }
}
