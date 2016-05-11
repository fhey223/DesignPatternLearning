using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{

    /// <summary>
    /// TODOProxy
    /// by gouyf
    /// 2016/5/4 14:28:00
    /// </summary>
    public class Proxy : IGiveGift
    {
        private Pursuit gg;
        public string PursuitName { get; set; }
        public string Name { get; set; }

        public Proxy(Girl mm,string PursuitName)
        {
            gg=new Pursuit(mm, PursuitName);
            this.PursuitName = PursuitName;
        }
        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}
