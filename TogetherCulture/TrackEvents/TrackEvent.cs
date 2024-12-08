using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.TrackEvents
{
    public class TrackEvent:Track
    {
        public DataTable SearchEvent(string eventN)
        {
            string query = "select users.first_name,users.last_name,bookings.booking_id,bookings.booking_date,events.event_name,events.event_date,events.event_time,events.location from bookings join events on bookings.event_id = events.event_id join users on users.user_id = bookings.user_id where events.event_name = '" + eventN + "'";
            DataTable x = DBSingleton.Instance.ExecuteQuery(query);
            return x;
        }
    }
}
