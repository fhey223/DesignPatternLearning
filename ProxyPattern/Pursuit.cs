using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{

    /// <summary>
    /// TODOPursuit
    /// by gouyf
    /// 2016/5/4 14:19:39
    /// </summary>
    public class Pursuit : IGiveGift
    {
        Girl mm;
        public string Name { get; set; }

        public Pursuit(Girl mm,string name)
        {
            this.mm = mm;
            this.Name = name;
        }
        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name+":"+ Name+"送你巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + "送你鲜花");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + "送你鲜花");
        }
    }
}
