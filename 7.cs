/* sealed 키워드 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    class FolderPhone
    {
        public virtual void Network()
        {
            Console.WriteLine("위피");
        }
    }
    class ThreeGPhone : FolderPhone
    {
        public sealed override void Network()
        {
            Console.WriteLine("와이브로");
        }
    }
    class SmartPhone : ThreeGPhone
    {
        public override void Network()
        {
            Console.WriteLine("와이파이");
        }
    }
    internal class _7
    {
        static void Main(string[] args)
        {
            FolderPhone phone = new FolderPhone();
            ThreeGPhone threeGPhone = new ThreeGPhone();
            phone.Network();
            threeGPhone.Network();
        }
    }
}
