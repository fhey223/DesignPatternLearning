using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小黑");
            Console.WriteLine("\n小黑今天的装饰：");

            Sneakers pqx = new Sneakers();
            BigTrouser kk = new BigTrouser();
            TShirts dtx =new TShirts();
            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();
            Console.Read();
        }
    }
}
