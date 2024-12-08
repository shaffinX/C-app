using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCulture.DataBase;

namespace TogetherCulture.AddMem
{
    public class Approve:Member
    {
        public Approve() { }
        public bool suspend(int userID) { return false; }
        public bool approve(int userID, string memTy) {
            string uti, unuti;
            if (memTy == "Community Member")
            {
                uti = "Access to weekly community events.\nParticipation in member forums.";
                unuti = "Free access to training sessions.\nSuggest Events";

            }
            else if(memTy == "Key Access Member")
            {
                uti = "Access to weekly community events.\nParticipation in member forums.\nFree access to training sessions.";
                unuti = "Suggest Events";
            }
            else
            {
                uti = "Access to weekly community events.\nParticipation in member forums.\nFree access to training sessions.\nSuggest Events";
                unuti = "none";
            }
            string query = "update users set user_type = 'Member', status = 'Active' where user_id = " + userID + ";update memberships set membership_type = '" + memTy + "' where user_id = " + userID+ ";insert into dashboard(user_id,benefits_used,benefits_unutilized) values("+userID+",'"+uti+"','"+unuti+"');";
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
