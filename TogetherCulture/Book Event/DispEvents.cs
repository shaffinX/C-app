using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.Book_Event
{
    public class DispEvents
    {
        public DataTable Display()
        {
            string query = "select * from events";
            DataTable res = DBSingleton.Instance.ExecuteQuery(query);
            return res;
        }
    }
}
