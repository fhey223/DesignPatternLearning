using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Work ww=new Work();
            ww.Hour = 9;
            ww.Write();
            ww.Hour = 13;
            ww.Write();
            ww.Hour = 15;
            ww.Write();
            ww.Finish = false;
            ww.Hour = 18;
            ww.Write();

            ww.Hour = 20;
            ww.Write();
            ww.Hour = 22;
            ww.Write();
            Console.Read();
        }
    }
}
