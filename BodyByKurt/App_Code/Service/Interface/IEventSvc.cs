using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyByKurt.Models;

namespace BodyByKurt.Service.Interface
{
    public interface IEventSvc
    {
        List<Event> selectAllEvents();
        List<Event> searchEvents(Event obj);
        Event selectEvent(String key);
        Boolean insertEvent(Event obj);
        Boolean updateEvent(Event obj);
        Boolean deleteEvent(Event obj);
    }
}
