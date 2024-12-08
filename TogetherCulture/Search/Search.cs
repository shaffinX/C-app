using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCulture.Search
{
    public interface Search
    {
        public DataTable SearchName(string name);
        public DataTable SearchEvent(string eventN);
    }
}
