using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public class InitialContext
    {
        public Object lookup(String jndiName)
        {
            if (jndiName.Equals("SERVICE1",StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Looking up and creating a new Service1 object");
                return new Service1();
            }
            else if (jndiName.Equals("SERVICE2", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Looking up and creating a new Service2 object");
                return new Service2();
            }
            return null;
        }
    }
}
