using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.AddMem
{
    public class Suspend:Member
    {
        public bool suspend(int userID) {
            string query = "update users set status = 'Suspended' where user_id = " + userID;
            if (DBSingleton.Instance.ExecuteUpdate(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool approve(int userID, string memTy) { return false; }
    }
}
