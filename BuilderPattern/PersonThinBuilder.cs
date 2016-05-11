using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{

    /// <summary>
    /// TODOPersonThinBuilder
    /// by gouyf
    /// 2016/5/5 11:00:28
    /// </summary>
    class PersonThinBuilder : PersonBuillder
    {
        public PersonThinBuilder(Graphics g, Pen p) : base(g,p) { }
        public override void BuildHead()
        {
            g.DrawEllipse(p, 50, 20, 30, 30);
        }
        public override void BuildBody()
        {
            g.DrawEllipse(p, 60, 50, 10, 50);
        }
        public override void BuildArmLeft()
        {
            g.DrawEllipse(p, 60, 50, 40, 100);
        }

        public override void BuildArmRight()
        {
            g.DrawEllipse(p, 60, 50, 90, 100);
        }
        public override void BuildLegLeft()
        {
            g.DrawEllipse(p, 60, 100, 45, 150);
        }

        public override void BuildLegRight()
        {
            g.DrawEllipse(p, 70, 100, 85, 150);
        }
    }
}
