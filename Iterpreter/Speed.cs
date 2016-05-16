using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterpreter
{

    /// <summary>
    /// TODOSpeed
    /// by gouyf
    /// 2016/5/16 11:57:49
    /// </summary>
    public class Speed : Expression
    {
        private string speed;
        public override void Excute(string key, double value)
        {
            if (value < 500)
                speed = "慢速";
            else if (value >= 1000)
                speed = "快速";
            else
                speed = "中速";

            Console.WriteLine($"{speed}");
        }
    }
}
