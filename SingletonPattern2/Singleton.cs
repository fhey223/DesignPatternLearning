using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern2
{

    /// <summary>
    /// TODOSingleton
    /// by gouyf
    /// 2016/5/10 14:54:58
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;
        private  static readonly object syncRoot = new object();
        private Singleton() { }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                 lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
           
            return instance;
        }
    }
    public sealed class Singleton2
    {
        private static readonly Singleton2 instance = new Singleton2();
        private Singleton2() { }
        public static Singleton2 GetInstance()
        {
            return instance;
        }
    }
}
