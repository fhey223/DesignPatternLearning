using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    public class EJBService : IBusinessService
    {
        public void doProcessing()=>  Console.WriteLine("Processing task by invoking EJB Service");
    }
}
