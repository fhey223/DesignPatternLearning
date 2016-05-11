using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    /// <summary>
    /// TODOConcreteCollegue1
    /// by gouyf
    /// 2016/5/11 15:27:26
    /// </summary>
    public class ConcreteCollegue1:Colleage
    {
        public ConcreteCollegue1(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("同事1收到的消息" + message);
        }

        public override void Send(string message)
        {
            mediator.Send(message,this);
        }
    }
}
