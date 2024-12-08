using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.Events
{
    public class CreateEvent:Event
    {
        public bool create(string ename,string loc, string des,string date, string time)
        {
            string query = "insert into events(event_name,event_date,event_time,location,description) values('" + ename + "','" + date + "','" + time + "','" + loc + "','" + des + "')";
            if (DBSingleton.Instance.ExecuteUpdate(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
