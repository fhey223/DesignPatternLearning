using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{

    /// <summary>
    /// TODOManager
    /// by gouyf
    /// 2016/5/11 13:50:15
    /// </summary>
    public abstract class Manager
    {
        protected string name;
        //管理的上级
        protected Manager superior;

        public Manager(string name)
        {
            this.name = name;
        }
        //设置管理者的上级
        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }
        //申请请求
        abstract public void RequestApplications(Request request);
    }
}
