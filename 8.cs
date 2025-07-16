/* switch, case문 데이터형 조건 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _8
    {
        static void Main(string[] args)
        {
            object obj = null;

            Console.WriteLine("숫자형태로 입력하시오");
            string s = Console.ReadLine();
            //TryParse() 형변환을 시도하고 가능하면 True반환

            if (int.TryParse(s, out int out_i)) //입력받은 s가 정수형이면 정수형으로 형변환해주고 정수형 변수 out_i에 저장
            {
                obj = out_i;
            }
            else if (float.TryParse(s, out float out_f))
            {
                obj = out_f;
            }
            else
            {
                obj = s;
            }

            switch (obj)
            {
                case int i when i>= 0:
                    {
                        Console.WriteLine("{0}은 양의 int 형식입니다.", i);
                        break;
                    }
                case int i :
                    {
                        Console.WriteLine("{0}은 음의 int 형식입니다.", i);
                        break;
                    }
                case float f when f >= 0:
                    {
                        Console.WriteLine("{0}은 양의 float 형식입니다.", f);
                        break;
                    }
                case float f :
                    {
                        Console.WriteLine("{0}은 음의 float 형식입니다.", f);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("{0}은 모르는 형식입니다.", obj);
                        break;
                    }
            }
        }
    }
}
