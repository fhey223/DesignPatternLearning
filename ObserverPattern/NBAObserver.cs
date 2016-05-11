using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    /// <summary>
    /// TODONBAObserver
    /// by gouyf
    /// 2016/5/5 18:41:44
    /// </summary>
    class NBAObserver: Observer
    {
        public NBAObserver(string name, Secretary sub):base(name,sub)
        {
        }
        public override void Update()
        {
            Console.WriteLine("{0}{1}xxxxxxNBA", sub.SecretaryAction, name);
        }
    }
}
