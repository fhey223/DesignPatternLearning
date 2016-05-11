using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{

    /// <summary>
    /// TODOClass1
    /// by gouyf
    /// 2016/5/9 10:52:28
    /// </summary>
    class Forwards : Player
    {
        public Forwards(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("前锋{0}进攻",name);
        }

        public override void Defense()
        {
            Console.WriteLine("前锋{0}防守", name);
        }
    }
    class Center : Player
    {
        public Center(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("中锋{0}进攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("中锋{0}防守", name);
        }
    }
    class Guards : Player
    {
        public Guards(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("后卫{0}进攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("后卫{0}防守", name);
        }
    }
}
