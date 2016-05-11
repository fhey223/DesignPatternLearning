using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternOpertion
{
    /// <summary>
    /// TODOIFactory
    /// by gouyf
    /// 2016/5/4 16:09:24
    /// </summary>
    public interface IFactory
    {
        Operation CreaOperation();
    }
}
