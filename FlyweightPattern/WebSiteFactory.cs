using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{

    /// <summary>
    /// TODOWebSiteFactory
    /// by gouyf
    /// 2016/5/12 17:36:48
    /// </summary>
    public class WebSiteFactory
    {
        private Hashtable flyweights = new Hashtable();

        /// <summary>
        /// 获取网站分类
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public WebSite GetWebSiteCategory(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key,new ConcreteWebSite(key));
            }
            return flyweights[key] as WebSite;
        }

        public int GetWebSiteCount()
        {
            return flyweights.Count;
        }
    }
}
