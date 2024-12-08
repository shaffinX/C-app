using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.Dashboard
{
    public class BenefitsDisp:Dash
    {
        public DataTable showEvents(int userid) { return null; }
        public DataTable showBenefits(int userid)
        {
            string query = "select benefits_used,benefits_unutilized from dashboard where user_id = " + userid;
            DataTable res = DBSingleton.Instance.ExecuteQuery(query);
            return res; 
        }
    }
}
