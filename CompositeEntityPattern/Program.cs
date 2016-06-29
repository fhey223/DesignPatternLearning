using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.setData("Test", "Data");
            client.printData();
            client.setData("Second Test", "Data1");
            client.printData();
            Console.ReadKey();
        }
    }
}
