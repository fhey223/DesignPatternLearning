using System;

namespace FacadePattern
{
    /// <summary>
    ///     TODOClass1
    ///     by gouyf
    ///     2016/5/5 10:19:38
    /// </summary>
    //股票1
    public class Stock1
    {
        public void Sell() => Console.WriteLine("股票1卖出");

        public void Buy() => Console.WriteLine("股票1买入");
    }

    public class Stock2
    {
        public void Sell() => Console.WriteLine("股票2卖出");

        public void Buy() => Console.WriteLine("股票2买入");
    }

    public class Stock3
    {
        public void Sell() => Console.WriteLine("股票3卖出");

        public void Buy() => Console.WriteLine("股票3买入");
    }
}