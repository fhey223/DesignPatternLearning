using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    public class BusinessDelegate
    {
        private BusinessLookUp lookupService = new BusinessLookUp();
        private IBusinessService businessService;
        private String serviceType;

        public void setServiceType(String serviceType)
        {
            this.serviceType = serviceType;
        }

        public void doTask()
        {
            businessService = lookupService.getBusinessService(serviceType);
            businessService.doProcessing();
        }
    }
}
