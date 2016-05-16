using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{

    /// <summary>
    /// TODOAction
    /// by gouyf
    /// 2016/5/16 12:25:55
    /// </summary>
    public abstract  class Action
    {
        public abstract void GetManConclusion(Man concreElementA);
        public abstract void GetWomanConclusion(Woman concreElementB);
    }
}
