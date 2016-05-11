using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    /// <summary>
    /// TODOStockObserver
    /// by gouyf
    /// 2016/5/5 17:29:07
    /// </summary>
    class StockObserver: Observer
    {

        public StockObserver(string name, Secretary sub):base(name,sub)
        {
        }
        public override void Update()
        {
            Console.WriteLine("{0}{1}xxxxxxg",sub.SecretaryAction,name);
        }
    }
    
}
