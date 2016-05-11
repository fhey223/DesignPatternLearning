using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass a = new DemoClass();
            a.i = 10;
            a.iArr = new int[] { 8, 9, 10 };
            DemoClass b = a.Clone1();
            DemoClass c = a.Clone2();

            // 更改 a 对象的iArr[0], 导致 b 对象的iArr[0] 也发生了变化 而 c不会变化
            a.iArr[0] = 88;

            Console.WriteLine("MemberwiseClone");
            Console.WriteLine(b.i);
            foreach (var item in b.iArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Clone2");
            Console.WriteLine(c.i);
            foreach (var item in c.iArr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
