using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Compostite root = new Compostite("root");
            root.Add(new Leaf("leaf1"));
            root.Add(new Leaf("leaf2"));

            Compostite comp = new Compostite("Compostite X");
            comp.Add(new Leaf("leaf x1"));
            comp.Add(new Leaf("leaf x2"));
            root.Add(comp);

            Compostite comp2 = new Compostite("Compostite XY");
            comp2.Add(new Leaf("leaf xy1"));
            comp2.Add(new Leaf("leaf xy2"));
            comp.Add(comp2);

            root.Add(new Leaf("leaf 3"));

            Leaf leaf=new Leaf("leaf 4");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
            Console.Read();
        }
    }
}
