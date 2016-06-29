using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPattern
{
    public class Client
    {
        private CompositeEntity compositeEntity = new CompositeEntity();

        public void printData()
        {
            for (int i = 0; i < compositeEntity.getData().Length; i++)
            {
                Console.WriteLine("Data: " + compositeEntity.getData()[i]);
            }
        }

        public void setData(String data1, String data2)
        {
            compositeEntity.setData(data1, data2);
        }
    }
}
