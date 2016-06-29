using InterceptingFilterPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern
{
    public class FilterChain
    {
        private List<IFilter> filters = new List<IFilter>();
        private Target _target;

        public void AddFilter(IFilter filter)
        {
            filters.Add(filter);
        }

        public void Execute(String request)
        {
            foreach (var filter in filters)
            {
                 filter.Execute(request);
            }
            _target.Execute(request);
        }

        public void SetTarget(Target target)
        {
            this._target = target;
        }
    }
}
