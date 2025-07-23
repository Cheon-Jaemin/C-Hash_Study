/* 컬렉션 Hashtable */

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class _17
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("사과", "apple");
            hashtable.Add("토마토", "tomato");
            hashtable["감자"] = "potato";
            hashtable["복숭아"] = "peach";

            Console.WriteLine("hashtable의 해시코드 {0}", hashtable.GetHashCode());
            foreach (object obj in hashtable.Keys) 
            {
                Console.WriteLine("{0} : {1}", obj, hashtable[obj]);
            }

            Hashtable hashtable1 = new Hashtable(); //새로운 객체 생성
            hashtable1.Add("사과", "apple");
            hashtable1.Add("토마토", "tomato");
            hashtable1["감자"] = "potato";
            hashtable1["복숭아"] = "peach";
            
            Console.WriteLine("hashtable1의 해시코드 {0}", hashtable1.GetHashCode());
            foreach (object obj in hashtable1.Keys) 
            {
                Console.WriteLine("{0} : {1}", obj, hashtable1[obj]);
            }
        }
    }
}
