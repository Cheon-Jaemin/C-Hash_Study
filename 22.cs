/* 값복사와 참조복사
 참조 복사 - 3번째 방식 (ref키워드 사용) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    class Product
    {
        private int price = 100;
        //접근제한자가 private일 때 속성외에 접근해서 값 변경하는 방법(참조방식)

        public ref int GetPrice()   //반환형을 ref제한자를 이용해서 메소드 선언
        {
            return ref price;   //price의 주소값이 반환됨
        }
        public void Print()
        {
            Console.WriteLine("Price : {0}", price);
        }
    }

    internal class _22
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            ref int ref_price = ref product.GetPrice(); //ref_price는 참조지역변수, 함수 호출뒤 반환되는 주소값이 가리키는 곳의 정수값이 반환됨
            int nomal_price = product.GetPrice();   // 값형식으로 스택에 저장된 데이터 출력
            
            product.Print();
            Console.WriteLine("ref_price = {0}", ref_price);
            Console.WriteLine("nomal_price = {0}", nomal_price);
            Console.WriteLine();

            ref_price = 200;    // 참조 값 변경
            Console.WriteLine("ref_price값 변경후");
            product.Print();
            Console.WriteLine("ref_price = {0}", ref_price);
            Console.WriteLine("nomal_price = {0}", nomal_price);    // 값형식으로 스택에 저장된 데이터 출력
        }
    }
}
