using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入单价");
            string price = Console.ReadLine();
            Console.WriteLine("请输入数量");
            string num = Console.ReadLine();
            Console.WriteLine("请输入打折方式");
            string fuc = Console.ReadLine();
            CashContext csuper =new CashContext(fuc);
            double totalPrices = csuper.GetResult(Convert.ToDouble(price)* Convert.ToDouble(num));
            Console.WriteLine("单价：{0}，数量：{1}，合计：{2}", price,num, totalPrices);
            Console.ReadLine();
        }
    }
}
