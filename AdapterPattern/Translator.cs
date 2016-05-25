namespace AdapterPattern
{
    /// <summary>
    ///     TODOTranslator
    ///     by gouyf
    ///     2016/5/9 11:01:50
    /// </summary>
    internal class Translator : Player
    {
        private readonly ForeignCenter wjzf = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            wjzf.Name = name;
        }

        public override void Attack()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }
}