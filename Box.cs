/* Box Class */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Box
    {
        private int width;
        private int height;
        public Box()
        {
            width = 20;
            height = 20;
        }

        public int Width
        {
            get { return this.width; }
            set 
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    Console.WriteLine("자연수를 입력하시오.");
                }
            }
        }
        public int Height
        { 
            get { return this.height; }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    Console.WriteLine("자연수를 입력하시오.");
                }
            }
        }
        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int area
        {
            get { return width * height; }
        }
    }
}
