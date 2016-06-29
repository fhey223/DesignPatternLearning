using System;

namespace ServiceLocatorPattern
{
    /// <summary>
    ///     TODOService1
    ///     by gouyf
    ///     2016/6/29 15:02:20
    /// </summary>
    public class Service1 : IService
    {
        public void execute()
        {
            Console.WriteLine("Executing Service1");
        }

        public string getName()
        {
            return "Service1";
        }
    }
}