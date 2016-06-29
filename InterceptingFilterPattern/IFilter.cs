using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern
{
    /// <summary>
    /// TODOIFilter
    /// by gouyf
    /// 2016/6/29 14:18:57
    /// </summary>
    public interface IFilter
    {
        void Execute(String request);
    }
}
