using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.AddMem
{
    public class DisplayAddMem
    {
        public DataTable Data()
        {
            DataTable x = DBSingleton.Instance.ExecuteQuery("select users.user_id,first_name,last_name,email,password,user_type,status,membership_type,interests from users join Memberships on Memberships.user_id = users.user_id where user_type!='Administrator'");
            return x;
        }
    }
}
