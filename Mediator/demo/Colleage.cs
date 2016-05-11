using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    /// <summary>
    /// TODOColleage
    /// by gouyf
    /// 2016/5/11 15:21:45
    /// </summary>
    public abstract class Colleage
    {
        protected Mediator mediator;

        protected Colleage(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Notify(string message);
    }
}
