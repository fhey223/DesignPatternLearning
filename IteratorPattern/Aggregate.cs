using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{

    /// <summary>
    /// TODOAggregate
    /// by gouyf
    /// 2016/5/10 11:37:32
    /// 聚集抽象类
    /// </summary>
    public abstract class Aggregate
    {
        public abstract Itertor CreateItertor();
    }
}
