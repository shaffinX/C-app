using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.Analyze
{
    public class Trends:AnallyzeT
    {
        public DataTable analyze()
        {
            string query = "SELECT e.event_name,COUNT(b.booking_id) AS total_bookings FROM Events e LEFT JOIN Bookings b ON e.event_id = b.event_id GROUP BY e.event_name ORDER BY total_bookings DESC";
            DataTable res=DBSingleton.Instance.ExecuteQuery(query);
            return res;
        }
    }
}
