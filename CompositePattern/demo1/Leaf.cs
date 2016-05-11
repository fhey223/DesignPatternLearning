using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{

    /// <summary>
    /// TODOLeaf
    /// by gouyf
    /// 2016/5/9 18:01:23
    /// </summary>
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Connot add to a leaf");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("Connot remove to a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth) + name);
        }
    }
}
