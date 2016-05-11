using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player b = new Forwards("巴提尔");
            b.Attack();
            Player m=new Guards("麦克");
            m.Attack();
            Player ym =new Translator("摇");
            ym.Attack();
            ym.Defense();
            Console.Read();
        }
    }
}
