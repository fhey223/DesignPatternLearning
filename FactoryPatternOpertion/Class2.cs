using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternOpertion
{

    /// <summary>
    /// TODOClass2
    /// by gouyf
    /// 2016/5/4 16:10:04
    /// </summary>
    public class AddFactory : IFactory
    {
        public Operation CreaOperation()
        {
            return new OperationAdd();
        }
    }
    public class SubFactory : IFactory
    {
        public Operation CreaOperation()
        {
            return new OperationSub();
        }
    }
    public class MulFactory : IFactory
    {
        public Operation CreaOperation()
        {
            return new OperationMul();
        }
    }
    public class DivFactory : IFactory
    {
        public Operation CreaOperation()
        {
            return new OperationDiv();
        }
    }
}
