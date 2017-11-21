using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingWorkFlowService
{
    public class ObjectMapper
    {
        public CalendarServiceReference.User MapFromUserToCalendar(UserServiceReference.User user)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserServiceReference.User, CalendarServiceReference.User>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<UserServiceReference.User, CalendarServiceReference.User>((UserServiceReference.User)user);
        }

        public CommunicationServiceReference.User MapFromUserToCommunication(UserServiceReference.User user)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserServiceReference.User, CommunicationServiceReference.User>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<UserServiceReference.User, CommunicationServiceReference.User>((UserServiceReference.User)user);
        }
    }
}