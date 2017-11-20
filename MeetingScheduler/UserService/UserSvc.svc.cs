using MeetingScheduler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UserService
{
    /// <summary>
    /// All User service related functions
    /// </summary>
    public class UserSvc : IUserSvc
    {
        /// <summary>
        /// Gets the user's representitive that would fill in for that user when they are not available
        /// </summary>
        /// <param name="user">The absent user</param>
        /// <returns>The representitive user</returns>
        public User GetRepresentitive(User user)
        {
            //Go to database and get user's presentitive 

            //Return Representitive
            return new User()
            {
                UserID = 2,
                ContactDetails = "07858467459",
                ContactPreference = ContactType.SMS,
                FirstName = "Tom",
                Surname = "Smith"
            };
        }
    }
}
