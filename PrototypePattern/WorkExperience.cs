using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{

    /// <summary>
    /// TODOWorkExperience
    /// by gouyf
    /// 2016/5/4 18:07:40
    /// </summary>
    public class WorkExperience : ICloneable
    {
        public string workDate { get; set; }
        public string company { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
