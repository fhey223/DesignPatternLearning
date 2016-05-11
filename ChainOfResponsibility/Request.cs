using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{

    /// <summary>
    /// TODORequest
    /// by gouyf
    /// 2016/5/11 13:46:28
    /// </summary>
    public class Request
    {
        //申请类型
        public string RequestType { get; set; }
        //申请内容
        public string RequestContent { get; set; }
        //数量
        public int Number { get; set; }
    }
}
