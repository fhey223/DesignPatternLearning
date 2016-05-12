using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory f =new WebSiteFactory();

            WebSite fx = f.GetWebSiteCategory("产品展示");
            fx.Use();

            WebSite fy = f.GetWebSiteCategory("产品展示");
            fy.Use();

            WebSite fz = f.GetWebSiteCategory("博客");
            fz.Use();

            Console.WriteLine("网站类别数量为："+f.GetWebSiteCount());
            Console.Read();
        }
    }
}
