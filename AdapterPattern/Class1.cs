using System;

namespace AdapterPattern
{
    /// <summary>
    ///     TODOClass1
    ///     by gouyf
    ///     2016/5/9 10:52:28
    /// </summary>
    internal class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {
        }

        public override void Attack() =>
            Console.WriteLine($"前锋{name}进攻");

        public override void Defense() =>
            Console.WriteLine($"前锋{name}防守");
    }

    internal class Center : Player
    {
        public Center(string name) : base(name)
        {
        }

        public override void Attack() =>
            Console.WriteLine($"中锋{name}进攻");


        public override void Defense() =>
            Console.WriteLine($"中锋{name}防守");
    }

    internal class Guards : Player
    {
        public Guards(string name) : base(name)
        {
        }

        public override void Attack() =>
            Console.WriteLine($"后卫{name}进攻");

        public override void Defense() =>
            Console.WriteLine($"后卫{name}防守");
    }
}