/* 중첩의 반복문을 사용하여 2차원 배열의 초기값을 입력 받아 
 * 출력하는 코드를 작성 2차원 배열은 정수형으로 선언하고 배열의 이름은 arr */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class test6
    {
        static void Main(string[] args)
        {
            int hang = 2;
            int yeol = 3;

            int[,] arr = new int [hang, yeol];

            for (int i = 0; i < hang; i++)
            {
                for(int j = 0; j < yeol; j++)
                {
                    Console.WriteLine("정수를 입력하세요.");
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < yeol; j++)
                {
                    Console.WriteLine("arr[{0}, {1}] = {2}", i, j, arr[i, j]);
                }
            }
        }
    }
}
