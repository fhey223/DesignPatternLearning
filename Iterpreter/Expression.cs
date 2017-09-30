using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterpreter
{

    /// <summary>
    /// TODOExpression
    /// by gouyf
    /// 2016/5/16 10:21:51
    /// </summary>
    public abstract class Expression
    {
        public void Interpret(PlayContext context)
        {
            if (context.PlayText.Length > 0)
            {
                string playKey = context.PlayText.Substring(0, 1);
                context.PlayText = context.PlayText.Substring(2);
                double playValue = Convert.ToDouble(context.PlayText.Substring(0, context.PlayText.IndexOf(" ")));
                context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(" ") + 1);
                Excute(playKey, playValue);
            }
        }
        //执行
        public abstract void Excute(string key, double value);
    }
}
