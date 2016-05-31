using System;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Player b = new Forwards("巴提尔");
            //Player m = new Guards("麦克");
            //Player ym = new Translator("摇");
            new Forwards("巴提尔").Attack();
            new Guards("麦克").Attack();
            new Translator("摇").Attack();
            new Translator("摇").Defense();
            Console.Read();
        }
    }
}