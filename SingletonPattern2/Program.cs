using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton2 s1 = Singleton2.GetInstance();
            Singleton2 s2 = Singleton2.GetInstance();
            if (s1==s2)
            {
                Console.WriteLine("两个对象是相同的");
            }
            Console.Read();
        }
    }
}
