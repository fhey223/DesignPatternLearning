using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{

    /// <summary>
    /// TODORequest
    /// by gouyf
    /// 2016/5/10 17:58:20
    /// </summary>
    public class Request
    {
        //申请类别
        public string RequestType { get; set; }
        //申请内容
        public string RequestContent { get; set; }
        //数量
        public int Number { get; set; }
    }
}
