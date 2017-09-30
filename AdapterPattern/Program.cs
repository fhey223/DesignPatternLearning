using System;

namespace AdapterPattern
{
    /// <summary>
    /// 适配器模式（Adapter Pattern）
    /// </summary>
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