namespace AdapterPattern
{
    /// <summary>
    ///     TODOplayer
    ///     by gouyf
    ///     2016/5/9 10:49:57
    /// </summary>
    internal abstract class Player
    {
        protected string name;

        public Player(string name) 
        {
            this.name = name;
        }
        public abstract void Attack();
        public abstract void Defense();
    }
}