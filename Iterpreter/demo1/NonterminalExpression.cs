using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterpreter.demo1
{

    /// <summary>
    /// TODONonterminalExpression
    /// by gouyf
    /// 2016/5/13 14:34:54
    /// </summary>
    public class NonterminalExpression:AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }
}
