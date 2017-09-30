using System;

namespace VisitorPattern
{
    internal class Program
    {
        /// <summary>
        /// 访问者模式
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var o = new ObjectStructure();
            o.Attach(new Man());
            o.Attach(new Woman());

            o.Display(new Success());
            o.Display(new Failing());
            o.Display(new Amativeness());

            Console.Read();
        }
    }
}