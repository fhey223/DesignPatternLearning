using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{

    /// <summary>
    /// TODOCashSuper
    /// by gouyf
    /// 2016/5/4 11:37:20
    /// </summary>
    abstract class CashSuper
    {
        public abstract double acceptCash(double money);
    }
}
