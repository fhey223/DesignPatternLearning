using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_Controller_Pattern;

namespace FrontControllerPattern
{
    public class Dispatcher
    {
        private StudentView studentView;
        private HomeView homeView;

        public Dispatcher()
        {
            studentView = new StudentView();
            homeView = new HomeView();
        }

        public void dispatch(String request)
        {
            if (request.Equals("STUDENT",StringComparison.CurrentCultureIgnoreCase))
                studentView.show();
            else
                homeView.show();
        }
    }
}
