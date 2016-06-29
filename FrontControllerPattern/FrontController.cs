using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontControllerPattern
{
    public class FrontController
    {
        private Dispatcher dispatcher;

        public FrontController()
        {
            dispatcher = new Dispatcher();
        }

        private bool isAuthenticUser()
        {
            Console.WriteLine("User is authenticated successfully.");
            return true;
        }

        private void trackRequest(String request)=> Console.WriteLine($"Page requested:{request}");

        public void dispatchRequest(String request)
        {
            //记录每一个请求
            trackRequest(request);
            //对用户进行身份验证
            if (isAuthenticUser())
            {
                dispatcher.dispatch(request);
            }
        }
    }
}
