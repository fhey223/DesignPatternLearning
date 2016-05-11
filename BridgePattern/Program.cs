using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetBrand ab;
            ab=new Android();
            ab.SetHandsetSoft(new HansetGame());
            ab.Run();

            ab.SetHandsetSoft(new HansetAddresslist());
            ab.Run();

            ab = new Ios();
            ab.SetHandsetSoft(new HansetGame());
            ab.Run();

            ab.SetHandsetSoft(new HansetAddresslist());
            ab.Run();

            Console.Read();
        }
    }
}
