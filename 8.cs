/* 2025 07 18 (금) 아침퀴즈 4번 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class _8
    {
        static void Main(string[] args)
        {
            double[] nArray = new double[6];
            double sum1 = 0;
            double sum2 = 0;

            for(int i = 0; i < nArray.Length; i++)
            {
                Console.WriteLine("실수를 입력하세요.");
                nArray[i] = double.Parse(Console.ReadLine());
                sum1 = (sum1 + nArray[i]);
            }

            for (int i = 0; i < nArray.Length; i++)
            {
                Console.Write("{0} ", nArray[i]);
            }
            Console.Write(sum1);
            Console.WriteLine();
            
            foreach(double i in nArray)
            {
                Console.Write("{0} ", i);
                sum2 = (sum2 + i);
            }
            Console.Write(sum2);
        }
    }
}
