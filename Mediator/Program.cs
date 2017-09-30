using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        /// <summary>
        /// 中介者模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            unitedNationSecurityCouncil UNSC = new unitedNationSecurityCouncil();

            USA USA=new USA(UNSC);
            Iraq Iraq = new Iraq(UNSC);

            //UNSC.country1 = USA;
            //UNSC.country2 = Iraq;

            USA.Declare("呃呃呃");
            Iraq.Declare("呼呼呼");

            Console.Read();
        }
    }
}
