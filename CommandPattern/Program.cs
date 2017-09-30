using System;

namespace CommandPattern
{
    /// <summary>
    /// 命令模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //开店前的准备
            Barbecuer cs=new Barbecuer();
            Command rc1Command=new BakeMuttonCommand(cs);
            Command rc2Command = new BakeMuttonCommand(cs);
            Command jcCommand=new BakeBakeChickenWingCommand(cs);
            Waiter fwy=new Waiter();

            //顾客点菜
            fwy.SetOrder(rc1Command);
            fwy.SetOrder(rc2Command);
            fwy.SetOrder(jcCommand);

            //通知厨房
            fwy.Notify();

            Console.Read();
        }
    }
}
