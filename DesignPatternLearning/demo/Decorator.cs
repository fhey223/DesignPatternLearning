using DesignPatternLearning.demo;

namespace DesignPatternLearning
{
    internal class Decorator : Component
    {
        protected Component component;
        public void SetComponent(Component component) => this.component = component;
        public override void Operation() => component?.Operation();
    }
}