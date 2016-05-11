using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{

    /// <summary>
    /// TODOCompostite
    /// by gouyf
    /// 2016/5/9 18:05:03
    /// </summary>
    public class Compostite : Component
    {
        private List<Component> children = new List<Component>();
        public Compostite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }
        public override void Remove(Component c)
        {
            children.Remove(c);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (var component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
