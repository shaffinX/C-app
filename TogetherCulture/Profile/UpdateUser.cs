using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCulture.Profile
{
    public interface UpdateUser
    {
        public bool changePass(int user_id, string password);
        public bool changeInterest(int user_id, string interest);
    }
}
