/* if else if문 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하시오");
            int score = int.Parse(Console.ReadLine());
            char grade = ' ';

            if(score >= 90)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade = 'B';
            }
            else if (score >= 70)
            {
                grade = 'C';
            }
            else
            {
                grade = 'D';
            }
            Console.WriteLine(grade);
        }
    }
}
