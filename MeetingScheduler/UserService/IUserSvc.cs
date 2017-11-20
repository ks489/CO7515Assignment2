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
    [ServiceContract]
    public interface IUserSvc
    {
        [OperationContract]
        User GetRepresentitive(User user);
    }
}
