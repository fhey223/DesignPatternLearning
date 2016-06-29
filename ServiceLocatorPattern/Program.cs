using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = ServiceLocator.getService("Service1");
            service.execute();
            service = ServiceLocator.getService("Service2");
            service.execute();
            service = ServiceLocator.getService("Service1");
            service.execute();
            service = ServiceLocator.getService("Service2");
            service.execute();
        }
    }
}
