using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    public class BusinessLookUp
    {
        public IBusinessService getBusinessService(String serviceType)
        {
            if (serviceType.Equals("EJB",StringComparison.OrdinalIgnoreCase))
            {
                return new EJBService();
            }
            else
            {
                return new JMSService();
            }
        }
    }
}
