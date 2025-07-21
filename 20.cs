/* 값복사와 참조복사
 참조 복사 - 1번째 방식 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _20
    {
        class Test
        {
            public int value = 10;  // value가 저장되어 있는 힙의 값이 10에서 20으로 바뀜
        }
        static void Change(Test input)  //클래스로 만들어진 인스턴스 객체
        { // 접근제한자가 private라도 클래스로 매개변수를 받고 있기 때문에 
          // 결국 input은 필드값인 value가 됨
            input.value = 20;
        }

        static void Main(string[] args)
        {
            Test test = new Test(); //클래스로 만들어진 인스턴스 객체는 메모리의 주소값이 들어감
            test.value = 10;
            Change(test);   //메소드 호출 후 test라는 클래스 인스턴스는 20이라는 객체를 가리키게 됨

            Console.WriteLine("클래스로 만들어진 인스턴스의 객체의 메소드 호출 후 변화 {0}", test.value);
        }
    }
}
