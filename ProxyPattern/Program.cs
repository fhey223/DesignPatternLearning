using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 代理模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Girl jiaojiao = new Girl();
            jiaojiao.Name = "李娇娇";
            Proxy dali = new Proxy(jiaojiao, "甲");
            dali.Name = "戴利";
            dali.PursuitName = "甲";
            dali.GiveChocolate();
            dali.GiveDolls();
            dali.GiveFlowers();
            Console.Read();
        }
    }
}
