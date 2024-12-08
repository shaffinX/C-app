using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCulture.Dashboard
{
    public class DashContt
    {
        private Dash ben;
        private Dash even;
        public DashContt()
        {
            ben = new BenefitsDisp();
            even = new EventsPart();
        }
        public DataTable showEvents(int userID)
        {
            return even.showEvents(userID);
        }
        public DataTable showBenefit(int userID) { 
            return ben.showBenefits(userID);
        }
    }
}
