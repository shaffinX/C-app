using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.Profile
{
    public class PassUpd:UpdateUser
    {
        public bool changePass(int user_id, string password)
        {
            string hashpass = Hash.Hash.ComputeSha256Hash(password);
            string query = $"update users set password = '{hashpass}' where user_id = {user_id}";
            if (DBSingleton.Instance.ExecuteUpdate(query)) {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool changeInterest(int user_id, string interest) { return false; }
    }
}
