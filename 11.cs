/* 2025/ 07/ 24 (목) 아침퀴즈 2번 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class _11
    {
        static int Div(int a, int b)
        {
            try
            {
                Console.WriteLine("나눗셈 시작");
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("나눗셈 중 예외 발생");
                throw e;
            }
            finally
            {
                Console.WriteLine("나눗셈 끝");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("제수를 입력");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("피제수를 입력");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} / {1} = {2}", a, b, Div(a, b));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("프로그램 종료");
            }
        }
    }
}
