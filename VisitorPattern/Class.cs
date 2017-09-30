using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{

    /// <summary>
    /// TODOSuccess
    /// by gouyf
    /// 2016/5/16 12:41:51
    /// 成功
    /// </summary>
    //成功
    public class Success : Action
    {
        public override void GetManConclusion(Man concreElementA)=>
            Console.WriteLine($"{concreElementA.GetType().Name}{this}时，背后多半有一个伟大的女人");

        public override void GetWomanConclusion(Woman concreElementB) =>
            Console.WriteLine($"{concreElementB.GetType().Name}{this.GetType().Name}时，背后多半有一个不成功的男人");
    }

    public class Failing : Action
    {
        public override void GetManConclusion(Man concreElementA) =>
            Console.WriteLine($"{concreElementA.GetType().Name}{this.GetType().Name}时，蒙头喝酒");

        public override void GetWomanConclusion(Woman concreElementB) =>
            Console.WriteLine($"{concreElementB.GetType().Name}{this.GetType().Name}时，眼泪汪汪");
    }
    public class Amativeness : Action
    {
        public override void GetManConclusion(Man concreElementA) =>
            Console.WriteLine($"{concreElementA.GetType().Name}{this.GetType().Name}时，不懂也要回装懂");

        public override void GetWomanConclusion(Woman concreElementB) =>
            Console.WriteLine($"{concreElementB.GetType().Name}{this.GetType().Name}时，懂也装作不懂");
    }
}
