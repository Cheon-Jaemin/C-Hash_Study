/* 클래스 만들기 carpicture */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace day4
{
    internal class CarPicture
    {
        // 필드
        private int car_width;
        private int car_height;
        public string car_name;
        public Color color;

        public CarPicture() // 매개변수가 없는 생성자
        {
            car_width = 200;
            car_height = 140;
            car_name = "casper";
            color = Color.DarkKhaki;
        }

        public CarPicture(int car_width, int car_height, string car_name, Color color) //매개변수가 있는 생성자
        {   
            this.car_width = car_width;
            this.car_height = car_height;
            this.car_name = car_name;
            this.color = color;
        }

        public int area
        {
            get { return car_width * car_height; }
        }

        public int Width    //getter선언 외부에서 필드를 억세스 할 수 있도록 
        {                   // 속성(프로퍼티)를 지정함.
            get { return this.car_width; }
            set
            {
                if (value > 0)  // set에 조건추가 
                {
                    this.car_width = value; //value라는 키워드롤 통해 어떤 값을 받을 수 있음
                }
            }
        }
        public int Height
        {
            get { return this.car_height; }
            set
            {
                if (value > 0)
                {
                    this.car_height = value;
                }
            }
        }

        public void MakeCar()
        {
            // Event Fire
            if (ProcessStarted != null)
            {
                ProcessStarted(this, EventArgs.Empty);
            }
            Step1();
            Step2();
            Step3();
            if (ProcessEnded != null)
            {
                ProcessEnded(this, EventArgs.Empty); // sender는 this, Args는 Empty
            }
        }
        public void Step1()
        {
            Console.WriteLine("Step #1");
        }
        public void Step2()
        {
            Console.WriteLine("Step #2");
        }
        public void Step3()
        {
            Console.WriteLine("Step #3");
        }

        public event EventHandler ProcessStarted;   //이벤트 시작 
        public event EventHandler ProcessEnded;   //이벤트 끝 
    }
}
