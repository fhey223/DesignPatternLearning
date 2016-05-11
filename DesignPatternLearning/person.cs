using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLearning
{

    /// <summary>
    /// TODOperson
    /// by gouyf
    /// 2016/5/3 14:35:15
    /// </summary>
    public class Person
    {
        public Person() { }

        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装饰的" + name);
        }  
    }
}
