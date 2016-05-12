using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{

    /// <summary>
    /// TODOFlyweightFactory
    /// by gouyf
    /// 2016/5/12 14:37:46
    /// </summary>
    public class FlyweightFactory
    {
        private Hashtable flyweights=new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("X",new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return flyweights[key] as Flyweight;
        }
    }
}
