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
    [ServiceContract]
    public interface ICalendarSvc
    {
        [OperationContract]
        bool CheckAvailability(User user, DateTime dateTime);
        [OperationContract]
        void InsertUserCalendarEvent(User user, DateTime dateTime);
    }
}
