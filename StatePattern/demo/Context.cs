using System;

namespace StatePattern.demo
{
    /// <summary>
    ///     TODOContext
    ///     by gouyf
    ///     2016/6/2 10:26:32
    /// </summary>
    public class Context
    {
        private State _state;

        public Context(State state)=> _state = state;

        public State State
        {
            get { return _state; }
            set { _state = value;
                Console.WriteLine($"当前状态：{State.GetType().Name}");
            }
            
        }

        public void Request() => State.Handle(this);
    }
}