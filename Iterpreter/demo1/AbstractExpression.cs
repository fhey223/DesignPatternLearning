using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterpreter.demo1
{

    /// <summary>
    /// TODOAbstractExpression
    /// by gouyf
    /// 2016/5/13 14:24:46
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
