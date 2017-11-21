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

        //public TEntity2 MapObject<TEntity1, TEntity2>(object origin)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<TEntity1, TEntity2>();
        //    });

        //    IMapper iMapper = config.CreateMapper();
        //    return iMapper.Map<TEntity1, TEntity2>((TEntity1)origin);
        //}

        //public IList<TEntity2> MapObject<TEntity1, TEntity2>(List<TEntity1> origin)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<TEntity1, TEntity2>();
        //    });

        //    IMapper iMapper = config.CreateMapper();

        //    List<TEntity2> list = new List<TEntity2>();
        //    origin.ForEach(x =>
        //    {
        //        var destination = iMapper.Map<TEntity1, TEntity2>((TEntity1)x);
        //        list.Add(destination);
        //    });
        //    return list;
        //}

        //public IEnumerable<TEntity2> MapObject<TEntity1, TEntity2>(IEnumerable<TEntity1> origin)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<TEntity1, TEntity2>();
        //    });

        //    IMapper iMapper = config.CreateMapper();

        //    IList<TEntity2> list = new List<TEntity2>();

        //    foreach (var item in origin)
        //    {
        //        var destination = iMapper.Map<TEntity1, TEntity2>((TEntity1)item);
        //        list.Add(destination);
        //    }
        //    return list;
        //}

        //public IEnumerable<TEntity2> MapObject<TEntity1, TEntity2>(IEnumerable<TEntity1> origin, MapperConfiguration config)
        //{

        //    IMapper iMapper = config.CreateMapper();

        //    IList<TEntity2> list = new List<TEntity2>();

        //    foreach (var item in origin)
        //    {
        //        var destination = iMapper.Map<TEntity1, TEntity2>((TEntity1)item);
        //        list.Add(destination);
        //    }
        //    return list;
        //}
    }
}