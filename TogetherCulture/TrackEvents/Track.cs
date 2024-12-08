using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCulture.TrackEvents
{
    public interface Track
    {
        public DataTable SearchEvent(string eventN);
    }
}
