/* string 클래스가 제공하는 다양한 메소드2 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _13
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning.";

            Console.WriteLine(greeting.Substring(0, 5));
            Console.WriteLine(greeting.Substring(5));

            string[] arr = greeting.Split(' ');
            Console.WriteLine("Word Count : {0}", arr.Length);

            Console.WriteLine("arr[0] = {0}", arr[0]);   //배열에 저장된 처음값
            Console.WriteLine("arr[1] = {0}", arr[1]);   //배열에 저장된 그 다음 값
            //Console.WriteLine("arr[1] = {0}", arr[2]);
        }
    }
}
