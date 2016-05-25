using System;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player b = new Forwards("巴提尔");
            b.Attack();
            Player m = new Guards("麦克");
            m.Attack();
            Player ym = new Translator("摇");
            ym.Attack();
            ym.Defense();
            Console.Read();
        }
    }
}