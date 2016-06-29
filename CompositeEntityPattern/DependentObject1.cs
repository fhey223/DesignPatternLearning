using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPattern
{
    public class DependentObject1
    {

        private String data;

        public void setData(String data)
        {
            this.data = data;
        }

        public String getData()
        {
            return data;
        }
    }
}
