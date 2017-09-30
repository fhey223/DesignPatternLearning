using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    /// <summary>
    /// TODOunitedNationSecurityCouncil
    /// by gouyf
    /// 2016/5/11 16:59:26
    /// </summary>
    public class unitedNationSecurityCouncil : UnitedNations
    {
        //public Country country1 { get;set; }
        //public Country country2 { get; set; }
        public override void Declare(string meggase, Country colleague)
        {
            colleague.GetMessage(meggase);
            //if (colleague == country1)
            //{
            //    country2.GetMessage(meggase);
            //}
            //else
            //{
            //    country1.GetMessage(meggase);
            //}
        }
    }
}
