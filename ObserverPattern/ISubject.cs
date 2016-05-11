using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// TODOISubject
    /// by gouyf
    /// 2016/5/5 17:52:12
    /// </summary>
    interface ISubject
    {
       void Attach(Observer observer);
        //减少
        void Detach(Observer observer);
        //通知
        void Notify();

        string SecretaryAction { get; set; }
    }
}
