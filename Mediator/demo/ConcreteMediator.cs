using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    /// <summary>
    /// TODOConcreteMediator
    /// by gouyf
    /// 2016/5/11 15:23:49
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        public ConcreteCollegue1 ConcreteCollegue1 { get; set; }
        public ConcreteCollegue2 ConcreteCollegue2 { get; set; }
        public override void Send(string message, Colleage colleage)
        {
            if (colleage == ConcreteCollegue1)
            {
                ConcreteCollegue2.Notify(message);
            }
            else
            {
                ConcreteCollegue1.Notify(message);
            }
        }
    }
}
