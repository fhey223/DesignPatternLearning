using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    /// <summary>
    /// TODOMediator
    /// by gouyf
    /// 2016/5/11 15:20:20
    /// </summary>
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleage colleage);
    }
}
