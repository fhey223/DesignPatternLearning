using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{

    /// <summary>
    /// TODOWork
    /// by gouyf
    /// 2016/5/6 15:44:21
    /// </summary>
    public class Work
    {
        private State current;

        public Work()
        {
            current = new ForenoonState();
        }

        public double Hour { get; set; }
        public bool Finish { get; set; }

        public void SetState(State s)
        {
            current = s;
        }

        public void Write()
        {
            current.Write(this);
        }
    }
}
