using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCulture.AddMem
{
    public interface Member
    {
        public bool approve(int userID,string memTy);
        public bool suspend(int userID);
    }
}
