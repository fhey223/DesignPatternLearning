using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterpreter
{

    /// <summary>
    /// TODOScale
    /// by gouyf
    /// 2016/5/16 11:28:51
    /// </summary>
    public class Scale : Expression
    {
        public override void Excute(string key, double value)
        {
            string scale=String.Empty;
            switch (Convert.ToInt32(value))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
            }
            Console.WriteLine($"{scale}");
        }
    }
}
