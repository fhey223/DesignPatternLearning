using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPattern
{
    public class CompositeEntity
    {
        private CoarseGrainedObject cgo = new CoarseGrainedObject();

        public void setData(String data1, String data2)
        {
            cgo.setData(data1, data2);
        }

        public String[] getData()
        {
            return cgo.getData();
        }
    }
}
