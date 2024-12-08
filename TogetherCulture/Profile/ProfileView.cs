using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.Profile
{
    public class ProfileView
    {
        public DataTable profileinfo(int uid)
        {
            string query = "select users.first_name,users.last_name,users.email,users.user_type,memberships.membership_type,memberships.interests from users join memberships on users.user_id = memberships.user_id where users.user_id=" + uid;
            DataTable x = DBSingleton.Instance.ExecuteQuery(query);
            return x;
        }
        public DataTable profileinfoAdmin(int uid) {
            string query = "select * from users where user_id = " + uid;
            DataTable x = DBSingleton.Instance.ExecuteQuery(query);
            return x;
        }
    }
}
