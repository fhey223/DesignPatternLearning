using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{

    /// <summary>
    /// TODOperson
    /// by gouyf
    /// 2016/5/16 12:17:01
    /// </summary>
    public abstract class person
    {
        public abstract void Accept(Action visitor);
    }
}
