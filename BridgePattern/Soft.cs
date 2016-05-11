using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{

    /// <summary>
    /// TODOSoft
    /// by gouyf
    /// 2016/5/10 15:34:17
    /// </summary>
    public class HansetGame : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机软件");
        }
    }
    public class HansetAddresslist : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机通讯录软件");
        }
    }
}
