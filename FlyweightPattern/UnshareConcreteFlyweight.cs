using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{

    /// <summary>
    /// TODOUnshareConcreteFlyweight
    /// by gouyf
    /// 2016/5/12 14:36:21
    /// </summary>
    public class UnshareConcreteFlyweight : Flyweight
    {
        public override void OPeration(int extrinsicstate)
        {
            Console.WriteLine("不共享的具体的Flyweight：" + extrinsicstate);
        }
    }
}
