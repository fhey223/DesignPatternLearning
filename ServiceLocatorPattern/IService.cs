using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    /// <summary>
    /// TODOIService
    /// by gouyf
    /// 2016/6/29 15:01:43
    /// </summary>
    public interface IService
    {
         String getName();
         void execute();
    }
}
