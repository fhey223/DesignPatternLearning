using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{

    /// <summary>
    /// TODOHandsetBrand
    /// by gouyf
    /// 2016/5/10 15:37:21
    /// </summary>
    public abstract class HandsetBrand
    {
        protected HandsetSoft soft;

        //设置手机软件
        public void SetHandsetSoft(HandsetSoft soft)=>
            this.soft = soft;
        //运行
        public abstract void Run();
    }
}
