using System;
using DesignPatternLearning.demo;

namespace DesignPatternLearning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region demo1
            //var c = new ConcreteComponent();
            //var d1 = new ConcreteDecoratorA();
            //var d2 = new ConcreteDecoratorB();
            //d1.SetComponent(c);
            //d2.SetComponent(d1);
            //d2.Operation();
            #endregion

            Person xc = new Person("小黑");
            Console.WriteLine("\n小黑今天的装饰：");
            Sneakers pqx = new Sneakers();
            BigTrouser kk = new BigTrouser();
            TShirts dtx = new TShirts();
            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();

            Console.Read();
        }
    }
}