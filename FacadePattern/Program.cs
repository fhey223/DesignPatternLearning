using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fund jijin= new Fund();
            //购买
            jijin.BuyFund();
            //赎回
            jijin.SellFund();
            Console.Read();
        }
    }
}
