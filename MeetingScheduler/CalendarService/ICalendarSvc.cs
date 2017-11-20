using MeetingScheduler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalendarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalendarSvc" in both code and config file together.
    [ServiceContract]
    public interface ICalendarSvc
    {
        [OperationContract]
        bool CheckAvailability(DateTime dateTime, User user);
    }
}
