using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{

    /// <summary>
    /// TODOItertor
    /// by gouyf
    /// 2016/5/10 11:34:25
    /// 迭代器抽象类
    /// </summary>
    public abstract class Itertor
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
