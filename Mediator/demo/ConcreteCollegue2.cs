using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    /// <summary>
    /// TODOConcreteCollegue2
    /// by gouyf
    /// 2016/5/11 15:32:56
    /// </summary>
    public class ConcreteCollegue2: Colleage
    {
        public ConcreteCollegue2(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("同事2收到的消息" + message);
        }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }
    }
}
