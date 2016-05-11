using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    /// <summary>
    /// TODOCountry
    /// by gouyf
    /// 2016/5/11 16:43:08
    /// </summary>
    public abstract class Country
    {
        protected UnitedNations mediator;

        public Country(UnitedNations mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Declare(string message);
        public abstract void GetMessage(string message);
    }
}
