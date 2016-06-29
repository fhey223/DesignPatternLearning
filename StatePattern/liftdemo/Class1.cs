using System;

namespace StatePattern.liftdemo
{
    internal class OpenningState : LiftState
    {
        public readonly Context context;

        public OpenningState(State state) : base(state)
        {
        }

        public OpenningState(Context context, State state) : base(state)
        {
            this.context = context;
        }

        /** 
         * 开启当然可以关闭了，我就想测试一下电梯门开关功能 
         * 
         */

        public override void close()
        {
            {
                //状态修改  
                context.setLiftState(new ClosingState);
                //动作委托为CloseState来执行  
                context.getLiftState();
            }
        }

        //打开电梯门  
        public override void open()
        {
            Console.WriteLine("lift open");
        }

        //门开着电梯就想跑，这电梯，吓死你！  
        public override void run()
        {
            //do nothing;  
        }

        //开门还不停止？  
        public override void stop()
        {
            //do nothing;  
        }
    }

/** 
 * 电梯门关闭以后，电梯可以做哪些事情  
 */

    public class ClosingState : LiftState
    {
        public readonly Context context;

        public ClosingState(State state) : base(state)
        {
        }

        public ClosingState(Context context, State state) : base(state)
        {
            this.context = context;
        }

        //电梯门关闭，这是关闭状态要实现的动作  
        public override void close()
        {
            Console.WriteLine("lift close");
        }

//电梯门关了再打开，逗你玩呢，那这个允许呀  
        public override void open()
        {
            context.setLiftState(new OpenningState); //置为门敞状态  
            context.getLiftState();
        }

//电梯门关了就跑，这是再正常不过了  
        public override void run()
        {
            context.setLiftState(new RunningState); //设置为运行状态；  
            context.getLiftState();
        }

//电梯门关着，我就不按楼层  

        public override void stop()
        {
            context.setLiftState(new StoppingState); //设置为停止状态；  
            context.getLiftState().stop();
        }
    }

/** 
 * 电梯在运行状态下能做哪些动作  
 */

    public class RunningState : LiftState
    {
        public readonly Context context;

        public RunningState(Context context, State state) : base(state)
        {
            this.context = context;
        }

        //电梯门关闭？这是肯定了  
        public override void close()
        {
            //do nothing  
        }

//运行的时候开电梯门？你疯了！电梯不会给你开的  
        public override void open()
        {
            //do nothing  
        }

//这是在运行状态下要实现的方法  
        public override void run()
        {
            Console.WriteLine("lift run");
        }

//这个事绝对是合理的，光运行不停止还有谁敢做这个电梯？！估计只有上帝了  
        public override void stop()
        {
            context.setLiftState(new StoppingState); //环境设置为停止状态；  
            context.getLiftState().stop();
        }
    }


/** 
 * 在停止状态下能做什么事情  
 */

    public class StoppingState : LiftState
    {
        public readonly Context context;

        public StoppingState(Context context, State state) : base(state)
        {
            this.context = context;
        }

        //停止状态关门？电梯门本来就是关着的！  
        public override void close()
        {
            //do nothing;  
        }

//停止状态，开门，那是要的！  
        public override void open()
        {
            context.setLiftState(new OpenningState);
            context.getLiftState().open();
        }

//停止状态再跑起来，正常的很  
        public override void run()
        {
            context.setLiftState(new RunningState);
            context.getLiftState().run();
        }

//停止状态是怎么发生的呢？当然是停止方法执行了  
        public override void stop()
        {
            Console.WriteLine("lift stop");
        }
    }
}