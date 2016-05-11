using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{

    /// <summary>
    /// TODOConcreIteratorDesc
    /// by gouyf
    /// 2016/5/10 12:27:29
    /// </summary>
    public class ConcreIteratorDesc : Itertor
    {
        private ConcreteAggregate aggregate;
        private int current;

        public ConcreIteratorDesc(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            current = aggregate.Count - 1;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[aggregate.Count-1];
        }

        public override bool IsDone()
        {
            return current <= 0 ? true : false;
        }

        public override object Next()
        {
            object ret = null;
            current--;
            if (current >= aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }
    }
}
