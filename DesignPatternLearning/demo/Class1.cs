using System;

namespace DesignPatternLearning.demo
{
    internal class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "new state";
            Console.WriteLine("具体装饰对象A");
        }
    }

    internal class ConcreteDecoratorB : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "new state";
            Console.WriteLine("具体装饰对象B");
        }

        private void AddedBehavior()
        {
            Console.WriteLine("装饰对象的操作方法");
        }
    }
}