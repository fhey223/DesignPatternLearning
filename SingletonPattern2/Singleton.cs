using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    //第一种（懒汉，线程不安全）
    public class Singleton1
    {
        private static Singleton1 instance;
        private Singleton1() { }

        public static Singleton1 GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton1();
            }
            return instance;
        }
    }

    //第二种（懒汉，线程安全）：
    public class Singleton2
    {
        private static Singleton2 instance;

        private Singleton2() { }
        private static readonly object _lock = new object();
        public static Singleton2 GetInstance()
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new Singleton2();
                }
            }

            return instance;
        }
    }

    //第三种（饿汉）：
    public class Singleton3
    {
        private static Singleton3 instance = new Singleton3();
        private Singleton3() { }
        public static Singleton3 GetInstance()
        {
            return instance;
        }
    }

    //第四种（静态内部类）：
    public class Singleton4
    {
        private static class SingletonHolder
        {
            public static Singleton4 INSTANCE = new Singleton4();
        }
        private Singleton4() { }
        public static Singleton4 GetInstance()
        {
            return SingletonHolder.INSTANCE;
        }
    }

    //第五种（双重校验锁）：
    public class Singleton5
    {
        private static Singleton5 instance;
        private static readonly object _lock = new object();
        protected Singleton5() { }
        public static Singleton5 Instance
        {
            get
            {
                if (instance == null)
                    lock (_lock)
                        if (instance == null)
                            instance = new Singleton5();
                return instance;
            }
        }
    }

    //第六种 静态初始化
    public sealed class Singleton6
    {
        private static readonly Singleton6 instance = null;
        static Singleton6()
        {
            instance = new Singleton6();
        }
        private Singleton6()
        {
        }
        public static Singleton6 Instance
        {
            get
            {
                return instance;
            }
        }
    }

    //第七种 延迟初始化
    public sealed class Singleton
    {
        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        public static void Hello()
        {
        }

        private class Nested
        {
            internal static readonly Singleton instance = null;
            static Nested()
            {
                instance = new Singleton();
            }
        }
    }
}
