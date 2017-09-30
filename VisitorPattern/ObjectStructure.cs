using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{

    /// <summary>
    /// TODOObjectStructure
    /// by gouyf
    /// 2016/5/16 12:53:29
    /// </summary>
    public class ObjectStructure
    {
        private IList<Person> elementes=new List<Person>();

        public void Attach(Person element)
        {
            elementes.Add(element);
        }
        public void Detach(Person element)
        {
            elementes.Remove(element);
        }

        public void Display(Action visitor)
        {
            foreach (var e in elementes)
            {
                e.Accept(visitor);
            }
        }
    }
}
