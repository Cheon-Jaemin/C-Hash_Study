/* 클래스 변수와 인스턴스 변수의 사용 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class _5
    {
        class Card
        {
            public String kind; //무늬
            public int number;  //숫자

            public static int width = 100;
            public static int height = 250;

            Random random = new Random();

            public void call(string name)
            {
                number = random.Next(1, 11);    //1에서 11사의 임의의 정수 생성
            }
            public static void totalNumber()
            {
                Console.WriteLine("카드의 총 수는 52장 입니다.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("카드의 크기는 가로 {0}, 세로 {1}입니다.", Card.width, Card.height);
            Card.totalNumber(); //클래스 메소드, 생성자 없이 바로 사용

            Card game1 = new Card();    //인스턴스 메소드를 사용하기 위해 인스턴스 생성
            game1.call("game1");    // call은 인스턴스 메소드
            game1.call("game1");

            Console.WriteLine("새로운 게임을 합니다.");
            Card.width = 150;
            Card.height = 350;
            Console.WriteLine("카드의 크기는 가로 {0}, 세로 {1}입니다.", Card.width, Card.height);
        }
    }
}
