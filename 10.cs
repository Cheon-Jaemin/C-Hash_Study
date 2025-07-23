/* 예외 되 던지기 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class _10
    {
        static int Divide(int divisor, int dividend)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return divisor / dividend;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                throw e;    //예외처리 후 호출한 쪽으로 되 던지기
            }
            finally // 되 던지기, return 전 필수적으로 수행
            {
                Console.WriteLine("Divide() 끝");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요. : ");
                string temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.Write("피제수를 입력하세요. : ");
                temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.WriteLine("{0} / {1} = {2}", divisor, dividend, Divide(divisor, dividend));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("에러 : {0}", e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("에러 : {0}", e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("에러 : {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
