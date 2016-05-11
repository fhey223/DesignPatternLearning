using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternOpertion
{

    /// <summary>
    /// TODOClass1
    /// by gouyf
    /// 2016/5/4 15:05:08
    /// </summary>
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            return NumberA / NumberB;
        }
    }
}
