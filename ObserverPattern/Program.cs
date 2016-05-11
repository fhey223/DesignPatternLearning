using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Secretary qt=new Secretary();
            StockObserver ts1=new StockObserver("one",qt);
            Observer ts2 = new NBAObserver("two", qt);
            qt.Update += new EventHandler(ts1.Update);
            qt.Update += new EventHandler(ts2.Update);
            
            qt.SecretaryAction = "come back";
            qt.Notify2();
            qt.Attach(ts1);
            qt.Attach(ts2);
            qt.Notify();

            Console.Read();
        }
    }
}
