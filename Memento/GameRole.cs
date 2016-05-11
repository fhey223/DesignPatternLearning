using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{

    /// <summary>
    /// TODOGameRole
    /// by gouyf
    /// 2016/5/9 15:02:07
    /// </summary>
    public class GameRole
    {
        RoleStateMemento roleState = new RoleStateMemento();
        //public int Vitality { get; set; }
        ////攻击力
        //public int Attack { get; set; }
        ////防御力
        //public int Defense { get; set; }
        //状态显示
        public void StateDisplayer()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine("体力：{0}", roleState.Vitality);
            Console.WriteLine("攻击力：{0}", roleState.Attack);
            Console.WriteLine("防御力：{0}", roleState.Defense);
            Console.WriteLine("");
        }
        //获取初始状态
        public void GetInitState()
        {
            roleState.Vitality = 100;
            roleState.Attack = 100;
            roleState.Defense = 100;
        }
        //战斗
        public void Fight()
        {
            roleState.Vitality = 0;
            roleState.Attack = 0;
            roleState.Defense = 0;
        }
        //保存角色状态
        public RoleStateMemento SaveState()
        {
            //RoleStateMemento memento = new RoleStateMemento();
            //memento = roleState.Clone();
            return roleState.Clone(); ;
            //return (new RoleStateMemento(roleState.Vitality, roleState.Attack, roleState.Defense));
        }
        //恢复角色状态
        public void RecoveryState(RoleStateMemento memento)
        {
            roleState = memento.Clone();
            //roleState.Vitality = memento.Vitality;
            //roleState.Attack = memento.Attack;
            //roleState.Defense = memento.Defense;
        }
    }
}
