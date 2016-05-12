using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{

    /// <summary>
    /// TODOConcreteWebSite
    /// by gouyf
    /// 2016/5/12 17:33:12
    /// </summary>
    public class ConcreteWebSite : WebSite
    {
        private string name = string.Empty;

        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use()
        {
            Console.WriteLine("网站分类："+name);
        }
    }
}
