/* 데이터의 은닉과 캡슐화 */

using System;

namespace day4
{
    class WaterHeater
    {
        protected int temperature;

        public void setTemperature(int temperature) // 매개변수는 있고 반환형x
        {
            if (temperature < 10 || 42 < temperature)
            {
                Console.WriteLine("10 ~ 42도 사이의 온도값을 입력하세요.");
                Console.WriteLine("물의 온도는 15도로 리셋됩니다.");
                this.temperature = 15;
                return;
            }
            this.temperature = temperature; // this가 붙으면 클래스 내의 멤버변수를 의미
        }

        public void turnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            WaterHeater heater = new WaterHeater(); //생성자를 통해 인스턴스 생성
            int temp;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("물의 온도를 입력하세요");
                temp = int.Parse(Console.ReadLine());
                heater.setTemperature(temp);
                heater.turnOnWater();
            }
            //heater.setTemperature = 15;   //protected로 선언한 변수
                                            //외부 접근 불가
        }
    }
}
