using MeetingScheduler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommunicationService
{
    /// <summary>
    /// All Communication service related functions
    /// </summary>
    public class CommunicationSvc : ICommunicationSvc
    {
        /// <summary>
        /// Finds out what type of messaging preference the user has and sends the message either by email or sms
        /// </summary>
        /// <param name="user">The user to send the message to</param>
        public void SendMessage(User user)
        {
            if(user.ContactPreference == ContactType.Email)
            {
                //Send this message by email
            }
            else if(user.ContactPreference == ContactType.SMS)
            {
                //Send this message by SMS
            }
        }
    }
}
