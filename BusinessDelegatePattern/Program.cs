using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessDelegate businessDelegate = new BusinessDelegate();
            businessDelegate.setServiceType("EJB");

            Client client = new Client(businessDelegate);
            client.doTask();

            businessDelegate.setServiceType("JMS");
            client.doTask();
        }
    }
}
