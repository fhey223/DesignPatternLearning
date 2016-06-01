using System;

namespace FactoryPattern
{
    /// <summary>
    ///     TODOLeiFeng
    ///     by gouyf
    ///     2016/5/4 16:25:02
    /// </summary>
    public class LeiFeng
    {
        public void Sweep() => Console.WriteLine("扫地");
        public void Wash() => Console.WriteLine("洗衣服");
        public void Buy() => Console.WriteLine("买东西");
    }
}