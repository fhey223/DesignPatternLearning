using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root=new ConcreteCompany("北京总公司");
            root.Add(new HRDepartment("总公司人力资源部"));
            root.Add(new FinaceDepartment("总公司财务部"));

            ConcreteCompany comp=new ConcreteCompany("上海华东分公司");
            comp.Add(new HRDepartment("华东分公司人力资源部"));
            comp.Add(new FinaceDepartment("华东分公司财务部"));
            root.Add(comp);

            ConcreteCompany comp1=new ConcreteCompany("南京办事处");
            comp1.Add(new HRDepartment("南京办事处人力资源部"));
            comp1.Add(new FinaceDepartment("南京办事处财务部"));
            comp.Add(comp1);

            Console.WriteLine("\n结构图：");
            root.Display(1);
            Console.WriteLine("\n职责：");
            root.LineOfDuty();

            Console.Read();
        }
    }
}
