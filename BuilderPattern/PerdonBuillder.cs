using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{

    /// <summary>
    /// TODOPerdonBuillder
    /// by gouyf
    /// 2016/5/5 10:49:54
    /// </summary>
    abstract class PersonBuillder
    {
        protected Graphics g;
        protected Pen p;

        public PersonBuillder(Graphics g, Pen p)
        {
            this.g = g;
            this.p = p;
        }

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();
    }
}
