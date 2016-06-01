namespace FactoryPattern
{
    /// <summary>
    ///     TODOClass2
    ///     by gouyf
    ///     2016/5/4 16:32:00
    /// </summary>
    public class UndergraduateFactory : IFactory
    {
        public LeiFeng CreateLeiFeng() => new Undergraduate();
    }

    public class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng() => new Volunteer();
    }
}