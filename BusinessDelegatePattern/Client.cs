using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    public class Client
    {

        BusinessDelegate businessService;

        public Client(BusinessDelegate businessService)
        {
            this.businessService = businessService;
        }

        public void doTask()
        {
            businessService.doTask();
        }
    }
}
