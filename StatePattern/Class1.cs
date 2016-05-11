using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{

    /// <summary>
    /// TODOClass1
    /// by gouyf
    /// 2016/5/6 17:49:17
    /// </summary>
    public class ForenoonState : State
    {
        public override void Write(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine("当前时间;{0}点上午工作",w.Hour);
            }
            else
            {
                w.SetState(new NoonState());w.Write();
            }
        }
    }
    public class NoonState : State
    {
        public override void Write(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("当前时间;{0}点中午工作", w.Hour);
            }
            else
            {
                w.SetState(new AferNoonState()); w.Write();
            }
        }
    }
    public class AferNoonState : State
    {
        public override void Write(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine("当前时间;{0}点下午工作", w.Hour);
            }
            else
            {
                w.SetState(new EveningState()); w.Write();
            }
        }
    }
    public class EveningState : State
    {
        public override void Write(Work w)
        {
            if (w.Finish)
            {
                w.SetState(new RestState());
                w.Write();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine("当前时间;{0}点加班工作", w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState()); w.Write();
                }
            }
        }
    }
    public class SleepingState : State
    {
        public override void Write(Work w)
        {
            Console.WriteLine("当前时间;{0}点睡觉了", w.Hour);
        }
    }
    public class RestState : State
    {
        public override void Write(Work w)
        {
            Console.WriteLine("当前时间;{0}点下班", w.Hour);
        }
    }
}
