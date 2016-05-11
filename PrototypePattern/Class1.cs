using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{

    /// <summary>
    /// TODOClass1
    /// by gouyf
    /// 2016/5/4 17:15:42
    /// </summary>
    abstract class prototype
    {
        public string id { get; }

        public prototype(string id)
        {
            this.id = id;
        }

        public abstract prototype Clone();
    }

    class ConcretePrototype: prototype
    {
        public ConcretePrototype(string id) : base(id) {}
        public override prototype Clone()
        {
            return (prototype) this.MemberwiseClone();
        }
    }
}
