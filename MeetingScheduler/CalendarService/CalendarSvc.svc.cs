using MeetingScheduler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalendarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalendarSvc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalendarSvc.svc or CalendarSvc.svc.cs at the Solution Explorer and start debugging.
    public class CalendarSvc : ICalendarSvc
    {
        /// <summary>
        /// Checks the availability of a user on a date and time.
        /// </summary>
        /// <param name="dateTime">Calendar date and time value</param>
        /// <param name="user">The user</param>
        /// <returns>True if user is available and False if not</returns>
        public bool CheckAvailability(DateTime dateTime, User user)
        {
            //Random True / False generator
            Random rand = new Random();
            return rand.Next(2) == 0;
        }
    }
}
