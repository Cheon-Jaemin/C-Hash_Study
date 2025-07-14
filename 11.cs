/* string 클래스가 제공하는 다양한 메소드 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class _11
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            // indexOf()
            Console.WriteLine("IndexOf \"GOOD\" : {0}", greeting.IndexOf("Good"));
            Console.WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            // LastIndexOf()
            Console.WriteLine("LastIndexOf \"GOOD\" : {0}", greeting.LastIndexOf("Good"));
            Console.WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));

            // StartsWith()
            Console.WriteLine("StartsWith \"GOOD\" : {0}", greeting.StartsWith("Good"));
            Console.WriteLine("StartsWith \"Morning\" : {0}", greeting.StartsWith("Morning"));

            // EndsWith()
            Console.WriteLine("EndsWith \"GOOD\" : {0}", greeting.EndsWith("Good"));
            Console.WriteLine("EndsWith \"Morning\" : {0}", greeting.EndsWith("Morning"));

            // Contains()
            Console.WriteLine("Contains \"Evening\" : {0}", greeting.Contains("Evening"));
            Console.WriteLine("Contains \"Morning\" : {0}", greeting.Contains("Morning"));

            // Replace()
            Console.WriteLine("Replaced \"Morning\" with \"Night\" : {0}", greeting.Replace("Morning", "Night"));
        }
    }
}
