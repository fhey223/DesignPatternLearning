using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m=new ConcreteMediator();

            ConcreteCollegue1 c1=new ConcreteCollegue1(m);
            ConcreteCollegue2 c2 = new ConcreteCollegue2(m);

            m.ConcreteCollegue1 = c1;
            m.ConcreteCollegue2 = c2;

            c1.Send("呃呃呃");
            c2.Send("呼呼呼");

            Console.Read();
        }
    }
}
