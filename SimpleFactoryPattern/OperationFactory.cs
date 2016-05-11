using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{

    /// <summary>
    /// TODOOperationFactory
    /// by gouyf
    /// 2016/5/4 15:41:41
    /// </summary>
    public class OperationFactory
    {
        public static Operation CreaOperation(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationDiv();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationSub();
                    break;
            }
            return oper;
        }
    }
}
