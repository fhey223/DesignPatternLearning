using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var extrinsicstate = 22;
            FlyweightFactory f =new FlyweightFactory();

            Flyweight fx = f.GetFlyweight("X");
            fx.OPeration(--extrinsicstate);

            Flyweight fy = f.GetFlyweight("Y");
            fy.OPeration(--extrinsicstate);

            Flyweight fz = f.GetFlyweight("Z");
            fz.OPeration(--extrinsicstate);

            UnshareConcreteFlyweight uf=new UnshareConcreteFlyweight();
            uf.OPeration(--extrinsicstate);

            Console.Read();
        }
    }
}
