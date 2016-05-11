using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{

    /// <summary>
    /// TODORoleStateMemento
    /// by gouyf
    /// 2016/5/9 15:10:07
    /// </summary>
    [Serializable]
    public class RoleStateMemento
    {
        public RoleStateMemento()
        {
        }
        public RoleStateMemento(int vit, int atk, int def)
        {
            this.Vitality = vit;
            this.Attack = atk;
            this.Defense = def;
        }
        //生命值
        public int Vitality { get; set; }
        //攻击力
        public int Attack { get; set; }
        //防御力
        public int Defense { get; set; }

        public RoleStateMemento Clone()
        {
            //深度克隆
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;//或者stream.Seek(0, SeekOrigin.Begin);
            return formatter.Deserialize(stream) as RoleStateMemento;

            //浅度克隆
            //return (RoleStateMemento)MemberwiseClone();
        }
    }
}
