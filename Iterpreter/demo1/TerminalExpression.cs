using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterpreter.demo1
{

    /// <summary>
    /// TODOTerminalExpression
    /// by gouyf
    /// 2016/5/13 14:33:01
    /// </summary>
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context) => Console.WriteLine("终端解释器");
    }
}
