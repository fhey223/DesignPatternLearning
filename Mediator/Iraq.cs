using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    /// <summary>
    /// TODOIraq
    /// by gouyf
    /// 2016/5/11 16:51:51
    /// </summary>
    public class Iraq:Country
    {
        public Iraq(UnitedNations mediator) : base(mediator)
        {
        }
        //声明
        public override void Declare(string message)
        {
            mediator.Declare(message, this);
        }
        //获得消息
        public override void GetMessage(string message)
        {
            Console.WriteLine("伊拉克获得对方消息：" + message);
        }
    }
}
