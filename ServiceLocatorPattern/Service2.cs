using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    class Service2 : IService
    {
        public void execute()
        {
            Console.WriteLine("Executing Service2");
        }

        public string getName()
        {
            return "Service2";
        }
    }
}
