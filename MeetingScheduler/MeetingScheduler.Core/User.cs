using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler.Core
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }        
        public ContactType ContactPreference { get; set; }
        public string ContactDetails { get; set; }
    }
}
