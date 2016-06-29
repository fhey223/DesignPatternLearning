using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern
{
    public class Client
    {
        private FilterManager _filterManager;

        public void SetFilterManager(FilterManager filterManager)
        {
            this._filterManager = filterManager;
        }

        public void SendRequest(string request)
        {
            _filterManager.FilterRequest(request);
        }
    }
}
