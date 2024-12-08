using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.Profile
{
    public class InterUpd:UpdateUser
    {
        public bool changePass(int user_id, string password) { return false; }
        public bool changeInterest(int user_id, string interest)
        {
            string query = $"update memberships set interests = '{interest}' where user_id = {user_id}";
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
