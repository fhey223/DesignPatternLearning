using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole link=new GameRole();
            link.GetInitState();
            link.StateDisplayer();

            //保存进度
            RoleStateCaretaker stateAdmin=new RoleStateCaretaker();
            stateAdmin.Memento = link.SaveState();

            //大战Boss，损耗严重
            link.Fight();
            link.StateDisplayer();

            //恢复之前状态
            link.RecoveryState(stateAdmin.Memento);
            link.StateDisplayer();
            Console.Read();
        }
    }
}
