using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{

    /// <summary>
    /// TODOBarbecuer
    /// by gouyf
    /// 2016/5/10 16:43:45
    /// 厨师
    /// </summary>
    public class Barbecuer
    {
        //烤羊肉
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串");
        }
        //烤鸡翅
        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅");
        }
    }
}
