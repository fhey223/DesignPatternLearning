using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    delegate void EventHandler();
    /// <summary>
    /// TODOSecretary
    /// by gouyf
    /// 2016/5/5 17:23:52
    /// </summary>
    class Secretary : ISubject
    {
        public event EventHandler Update;
        //同事列表
        private  IList<Observer> Observers = new List<Observer>();
        private string action;
        //增加
        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }
        //减少
        public void Detach(Observer observer)
        {
            Observers.Remove(observer);
        }
        //通知
        public void Notify()
        {
            foreach (var o in Observers)
            {
                o.Update();
            }
        }
        public void Notify2()
        {
            Update();
        }
        public string SecretaryAction{get; set; }
    }
}
