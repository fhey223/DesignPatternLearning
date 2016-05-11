using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{

    /// <summary>
    /// TODOPersonDirector
    /// by gouyf
    /// 2016/5/5 11:12:55
    /// </summary>
    class PersonDirector
    {
        private PersonBuillder pd;

        public PersonDirector(PersonBuillder pd)
        {
            this.pd = pd;
        }

        public void CreatePerson()
        {
            pd.BuildHead();
            pd.BuildBody();
            pd.BuildArmLeft();
            pd.BuildArmRight();
            pd.BuildLegLeft();
            pd.BuildLegRight();
        }
    }
}
