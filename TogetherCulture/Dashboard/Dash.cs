using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCulture.Dashboard
{
    public interface Dash
    {
        public DataTable showEvents(int userid);
        public DataTable showBenefits(int userid);
    }
}
