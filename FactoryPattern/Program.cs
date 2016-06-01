using System;

namespace FactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            var student = factory.CreateLeiFeng();
            student.Buy();
            student.Sweep();
            student.Wash();
            Console.ReadLine();
        }
    }
}