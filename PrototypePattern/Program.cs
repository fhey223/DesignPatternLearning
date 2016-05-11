using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume xh=new Resume("小黑");
            xh.SetPersonalInfo("女","11");
            xh.SetWorkExperience("2011-2013","加里顿");

            Resume xh1 = (Resume)xh.Clone();
            xh1.SetWorkExperience("2013-2014", "魔都一号");

            Resume xh2 = (Resume)xh.Clone();
            xh2.SetPersonalInfo("男","22");

            xh.Display();
            xh1.Display();
            xh2.Display();
            Console.Read();
        }
    }
}
