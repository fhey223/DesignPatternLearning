namespace DesignPatternLearning
{
    /// <summary>
    ///     TODOFinery
    ///     by gouyf
    ///     2016/5/3 14:39:46
    ///     服饰类
    /// </summary>
    public class Finery : Person
    {
        protected Person component;

        public void Decorate(Person component) => this.component = component;

        public override void Show() => component?.Show();
    }
}