using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{

    /// <summary>
    /// TODOConcreteAggregate
    /// by gouyf
    /// 2016/5/10 11:42:50
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        private IList<object> items=new List<object>();
        public override Itertor CreateItertor()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index,value);}
        }
    }
}
