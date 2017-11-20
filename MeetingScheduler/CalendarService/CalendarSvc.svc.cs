using MeetingScheduler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalendarService
{
    /// <summary>
    /// All Calendar service related functions
    /// </summary>
    public class CalendarSvc : ICalendarSvc
    {
        /// <summary>
        /// Checks the availability of a user on a date and time.
        /// </summary>
        /// <param name="dateTime">Calendar date and time value</param>
        /// <param name="user">The user</param>
        /// <returns>True if user is available and False if not</returns>
        public bool CheckAvailability(User user, DateTime dateTime)
        {
            //Random True / False generator
            Random rand = new Random();
            return rand.Next(2) == 0;
        }

        /// <summary>
        /// Gets the user's calendar and makes a scheduled booking for that user under that date and time
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public void InsertUserCalendarEvent(User user, DateTime dateTime)
        {
            //1. Gets the users calendar
            //2. Inserts the date and time event into the user's calendar
        }
    }
}
