using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontControllerPattern;

namespace Front_Controller_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontController frontController = new FrontController();
            frontController.dispatchRequest("HOME");
            frontController.dispatchRequest("STUDENT");
            Console.ReadKey();
        }
    }
}
