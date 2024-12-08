using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.Book_Event
{
    public class Participate
    {
        private Bookings mybooking;
        public Participate(int evid,int userid)
        {
            mybooking = new Bookings();
            mybooking.user_id = userid;
            mybooking.event_id = evid;
        }
        public bool bookevent()
        {
            string query = $"insert into bookings(event_id,user_id) values({this.mybooking.event_id},{this.mybooking.user_id})";
            string q1 = $"select user_id from bookings where event_id = {this.mybooking.event_id} and user_id = {this.mybooking.user_id}";
            DataTable a=DBSingleton.Instance.ExecuteQuery(q1);
            if (a.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                DBSingleton.Instance.ExecuteUpdate(query);
                return true;
            }
        }
    }
}
