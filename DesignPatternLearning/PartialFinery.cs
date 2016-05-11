using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLearning
{

    /// <summary>
    /// TODOClass1
    /// by gouyf
    /// 2016/5/3 14:55:47
    /// </summary>
    public partial class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("T恤");
            base.Show();
        }
    }
    public partial class Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋");
            base.Show();
        }
    }
    public partial class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("大垮裤");
            base.Show();
        }
    }
}
