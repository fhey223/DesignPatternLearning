using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{

    /// <summary>
    /// TODOCompany
    /// by gouyf
    /// 2016/5/10 9:42:08
    /// </summary>
    public abstract class Company
    {
        protected string name;

        protected Company(string name)
        {
            this.name = name;
        }
        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int depth);
        public abstract void LineOfDuty();//履行职责
    }
}
