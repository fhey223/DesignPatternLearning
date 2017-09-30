using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{

    /// <summary>
    /// TODOMan
    /// by gouyf
    /// 2016/5/16 12:18:56
    /// </summary>
    //男人
    public class Man : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManConclusion(this);
        }
    }
}
