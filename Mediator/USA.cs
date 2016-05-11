using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    /// <summary>
    /// TODOUSA
    /// by gouyf
    /// 2016/5/11 16:46:48
    /// </summary>
    public class USA : Country
    {
        public USA(UnitedNations mediator) : base(mediator)
        {
        }
        //声明
        public override void Declare(string message)
        {
            mediator.Declare(message,this);
        }
        //获得消息
        public override void GetMessage(string message)
        {
            Console.WriteLine("美国获得对方消息："+message);
        }
    }
}
