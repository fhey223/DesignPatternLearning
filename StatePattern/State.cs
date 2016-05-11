using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{

    /// <summary>
    /// TODOState
    /// by gouyf
    /// 2016/5/6 15:42:08
    /// </summary>
    public abstract class State
    {
        public abstract void Write(Work w);
    }
}
