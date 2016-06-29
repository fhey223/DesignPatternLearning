using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public class Cache
    {

        private List<IService> services;

        public Cache()
        {
            services = new List<IService>();
        }

        public IService getService(String serviceName)
        {
            foreach (var service in services)
            {
                if (service.getName().Equals(serviceName,StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Returning cached  " + serviceName + " object");
                    return service;
                }
            }
            return null;
        }

        public void addService(IService newService)
        {
            bool exists = false;
            foreach (var service in services)
            {
                if (service.getName().Equals(newService.getName(), StringComparison.CurrentCultureIgnoreCase))
                {
                    exists = true;
                }
            }
            if (!exists)
            {
                services.Add(newService);
            }
        }
    }
}
