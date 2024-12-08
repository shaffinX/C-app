using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCulture.Events
{
    public interface Event
    {
        public bool create(string ename, string loc, string des, string date, string time) {  return false; }
    }
}
