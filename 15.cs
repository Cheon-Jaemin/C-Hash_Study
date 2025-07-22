/* 2025/ 07/ 22 (화) 아침퀴즈 2번 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class _15
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("실수입력 : {0}", Math.Round(random.NextDouble(), 3));
            }
        }
    }
}
