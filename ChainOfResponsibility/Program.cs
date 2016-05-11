using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager jl=new CommonManager("金立");
            Majordomo zj=new Majordomo("宗键");
            GeneralManger zjl=new GeneralManger("钟晶利");
            jl.SetSuperior(zj);
            zj.SetSuperior(zjl);

            Request request=new Request();
            request.RequestType = "请假";
            request.RequestContent = "在家睡觉";
            request.Number = 1;
            jl.RequestApplications(request);

            Request request2 = new Request();
            request2.RequestType = "请假";
            request2.RequestContent = "在家睡觉";
            request2.Number = 4;
            jl.RequestApplications(request2);

            Request request3 = new Request();
            request3.RequestType = "加薪";
            request3.RequestContent = "在家睡觉";
            request3.Number = 500;
            jl.RequestApplications(request3);

            Request request4 = new Request();
            request4.RequestType = "加薪";
            request4.RequestContent = "在家睡觉";
            request4.Number = 1000;
            jl.RequestApplications(request4);

            Console.Read();
        }
    }
}
