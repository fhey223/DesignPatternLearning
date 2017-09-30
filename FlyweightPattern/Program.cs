using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        /// <summary>
        /// 享元模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WebSiteFactory f =new WebSiteFactory();

            WebSite fx = f.GetWebSiteCategory("产品展示");
            fx.Use(new User("菜鸟"));

            WebSite fy = f.GetWebSiteCategory("产品展示");
            fy.Use(new User("菜鸟2"));

            WebSite fz = f.GetWebSiteCategory("博客");
            fz.Use(new User("南海鳄神"));

            Console.WriteLine("网站类别数量为："+f.GetWebSiteCount());
            Console.Read();
        }
    }
}
