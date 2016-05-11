using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{

    /// <summary>
    /// TODOFinaceDepartment
    /// by gouyf
    /// 2016/5/10 10:02:05
    /// </summary>
    public class FinaceDepartment : Company
    {
        public FinaceDepartment(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0}公司财务收支管理", name);
        }

        public override void Remove(Company c)
        {
        }
    }
}
