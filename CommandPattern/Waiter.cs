using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{

    /// <summary>
    /// TODOWaiter
    /// by gouyf
    /// 2016/5/10 16:50:21
    /// </summary>
    public class Waiter
    {
        private IList<Command> orders=new List<Command>();

        //设置订单
        public void SetOrder(Command command)
        {
            if (command.ToString() == "CommandPattern.BakeBakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine("增加订单：{0}，时间：{1}",command.ToString(),DateTime.Now);
            }
        }
        //取消订单
        public void CancelOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine("取消订单：{0}，时间：{1}", command.ToString(), DateTime.Now);
        }
        //通知执行
        public void Notify()
        {
            foreach (var command in orders)
            {
                command.ExcuteCommand();
            }
            
        }
    }
}
