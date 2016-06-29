namespace ServiceLocatorPattern
{
    /// <summary>
    ///     TODOServiceLocator
    ///     by gouyf
    ///     2016/6/29 15:11:08
    /// </summary>
    public class ServiceLocator
    {
        private static readonly Cache cache = new Cache();

        public static IService getService(string jndiName)
        {
            var service = cache?.getService(jndiName);
            if (service != null)
                return service;
            var service1 = (IService)new InitialContext().lookup(jndiName);
            cache?.addService(service1);
            return service1;
        }
    }
}