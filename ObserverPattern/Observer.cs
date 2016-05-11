using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    /// <summary>
    /// TODOObserver
    /// by gouyf
    /// 2016/5/5 17:54:58
    /// </summary>
    abstract class Observer
    {
        protected string name;
        protected Secretary sub;

        public Observer(string name, Secretary sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public abstract void Update();
    }
}
