namespace StatePattern.liftdemo
{
    public abstract class LiftState
    {
        public LiftState(State state)
        {
            State = state;
        }
        public void setContext(Context context)
        {  
        this.context = context;
        }
        public State State { get; set; }
        public Context context { get; private set; }

        //首先电梯门开启动作  
        public abstract void open();

        //电梯门有开启，那当然也就有关闭了  
        public abstract void close();

        //电梯要能上能下，跑起来  
        public abstract void run();

        //电梯还要能停下来，停不下来那就扯淡了  
        public abstract void stop();
    }
}