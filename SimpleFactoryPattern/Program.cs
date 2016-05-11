using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            var strNunmberA = Console.ReadLine();
            Console.WriteLine("请选择运算符（+、-、*、、）：");
            var strOperate = Console.ReadLine();
            Console.WriteLine("请输入第二个数字：");
            var strNunmberB = Console.ReadLine();
            var oper = OperationFactory.CreaOperation(strOperate);
            oper.NumberA = Convert.ToDouble(strNunmberA);
            oper.NumberB = Convert.ToDouble(strNunmberB);
            var result = oper.GetResult();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
