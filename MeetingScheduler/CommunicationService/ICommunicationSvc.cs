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
    [ServiceContract]
    public interface ICommunicationSvc
    {
        [OperationContract]
        void SendMessage(User user);
    }
}
