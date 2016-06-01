using System;

namespace DesignPatternLearning.demo
{
    internal class ConcreteComponent : Component
    {
        public override void Operation() => Console.WriteLine("具体对象的操作");
    }
}