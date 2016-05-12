using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{

    /// <summary>
    /// TODOConcreteFlyweight
    /// by gouyf
    /// 2016/5/12 14:34:38
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        public override void OPeration(int extrinsicstate)
        {
            Console.WriteLine("具体的Flyweight："+ extrinsicstate);
        }
    }
}
