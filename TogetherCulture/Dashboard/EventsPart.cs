using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.Dashboard
{
    public class EventsPart:Dash
    {

        public DataTable showEvents(int userid) {
            string query = "select * from events join bookings on bookings.event_id = events.event_id where bookings.user_id = " + userid;
            DataTable res = DBSingleton.Instance.ExecuteQuery(query);   
            return res; 
        }
        public DataTable showBenefits(int userid) { return null; }
    }
}
