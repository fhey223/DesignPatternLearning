namespace StatePattern.liftdemo
{
    public class Context
    {
        //定义出所有的电梯状态  
        //    static  openningState = null;  
        //static  closeingState = null;  
        //static  runningState  = null;  
        //static  stoppingState = null;  

        //public void __construct()
        //    {
        //        self::openningState = new OpenningState();
        //        self::closeingState = new ClosingState();
        //        self::runningState = new RunningState();
        //        self::stoppingState = new StoppingState();

        //    }

        //定一个当前电梯状态  
        private LiftState _liftState;

        public LiftState getLiftState()
        {
            return _liftState;
        }

        public void setLiftState(LiftState liftState)
        {
            _liftState = liftState;
            //把当前的环境通知到各个实现类中  
            _liftState.setContext(this);
        }


        public void open()
        {
            _liftState.open();
        }

        public void close()
        {
            _liftState.close();
        }

        public void run()
        {
            _liftState.run();
        }

        public void stop()
        {
            _liftState.stop();
        }
    }
}