using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{

    /// <summary>
    /// TODOCommand
    /// by gouyf
    /// 2016/5/10 16:42:09
    /// </summary>
    public abstract class Command
    {
        protected Barbecuer receiver;

        protected Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }
        //执行命令
        abstract public void ExcuteCommand();
    }
}
