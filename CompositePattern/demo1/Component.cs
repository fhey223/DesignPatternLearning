using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{

    /// <summary>
    /// TODOComponent
    /// by gouyf
    /// 2016/5/9 17:52:37
    /// </summary>
    public abstract class Component
    {
        protected string name;

        protected Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}
