using BridgePattern.demo;
using System;

namespace BridgePattern
{
    internal class Program
    {
        /// <summary>
        /// 桥接模式
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            //HandsetBrand ab;
            //ab = new Android();
            //ab.SetHandsetSoft(new HansetGame());
            //ab.Run();

            //ab.SetHandsetSoft(new HansetAddresslist());
            //ab.Run();

            //ab = new Ios();
            //ab.SetHandsetSoft(new HansetGame());
            //ab.Run();

            //ab.SetHandsetSoft(new HansetAddresslist());
            //ab.Run();
            #region demo
            var ab = new RefinedAbstraction();
            ab.SetImplementor(new ConcretelmplementorA());
            ab.Operation();
            ab.SetImplementor(new ConcretelmplementorB());
            ab.Operation();
            Console.Read();
            #endregion
            Console.Read();
        }
    }
}